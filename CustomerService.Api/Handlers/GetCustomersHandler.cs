namespace CustomerService.Api.Handlers;

public static class GetCustomersHandler
{
    public static async Task<IResult> Handle(CustomerContext context) => 
        TypedResults.Ok(await context.Customers.ToListAsync());
}