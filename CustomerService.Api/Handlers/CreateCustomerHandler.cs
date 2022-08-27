namespace CustomerService.Api.Handlers;

public static class CreateCustomerHandler
{
    public static async Task<IResult> Handle(Models.Customer customer, IMapper mapper, CustomerContext context)
    {
        var result = await context.AddAsync(mapper.Map<Domain.Customer>(customer));
        await context.SaveChangesAsync();
        return Results.Ok(mapper.Map<Models.Customer>(result.Entity));
    }
}