using CustomerService.Api.Filters;
using CustomerService.Api.Handlers;

namespace CustomerService.Api.Endpoints;

public static class CustomerEndpoints
{
    public static void AddCustomerEndpoints(this WebApplication application)
    {
        var group = application.MapGroup("/api/customers");
        
        group.MapGet("/", GetCustomersHandler.Handle)
            .WithSummary("Get all customers from database");
        
        group.MapGet("/{id:long}", GetCustomerHandler.Handle)
            .WithSummary("Get customer by id from database");
        
        group.MapPost("/", CreateCustomerHandler.Handle)
            .AddEndpointFilter<ValidationFilter<Models.Customer>>()
            .WithSummary("Create a new customers");
        
        group.MapPut("/{id:long}", UpdateCustomerHandler.Handle)
            .AddEndpointFilter<ValidationFilter<Models.Customer>>()
            .WithSummary("Update customer information by customer id");
        
        group.MapDelete("/{id:long}", DeleteCustomerHandler.Handle)
            .WithSummary("Delete customer by id");
    }
}