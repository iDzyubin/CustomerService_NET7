namespace CustomerService.Api.Handlers;

public static class DeleteCustomerHandler
{
    public static async Task<IResult> Handle(long id, IMapper mapper, CustomerContext context)
    {
        var customer = await context.Customers.FindAsync(id);
        if (customer is null) 
            return TypedResults.NotFound();

        var result = context.Remove(customer);
        await context.SaveChangesAsync();
        
        return Results.Ok(mapper.Map<Models.Customer>(result.Entity));
    }
}