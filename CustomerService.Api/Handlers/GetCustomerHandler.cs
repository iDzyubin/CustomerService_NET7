namespace CustomerService.Api.Handlers;

public static class GetCustomerHandler
{
    public static async Task<Results<Ok<Models.Customer>, NotFound>> Handle(long id, IMapper mapper, CustomerContext context) =>
        await context.Customers.FindAsync(id) is { } customer
            ? TypedResults.Ok(mapper.Map<Models.Customer>(customer))
            : TypedResults.NotFound();
}