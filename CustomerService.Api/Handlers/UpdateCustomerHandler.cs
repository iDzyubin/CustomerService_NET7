namespace CustomerService.Api.Handlers;

public static class UpdateCustomerHandler
{
    public static async Task<Results<Ok<Models.Customer>, NotFound>> Handle(long id, Models.Customer customer, IMapper mapper, CustomerContext context)
    {
        var entity = await context.Customers.FindAsync(id);
        if (entity is null) 
            return TypedResults.NotFound();

        entity.FirstName = customer.FirstName;
        entity.LastName = customer.LastName;
        entity.Age = customer.Age;
        
        var result = context.Update(entity);
        await context.SaveChangesAsync();
        
        return TypedResults.Ok(mapper.Map<Models.Customer>(result.Entity));
    }
}