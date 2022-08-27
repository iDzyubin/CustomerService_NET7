namespace CustomerService.Api.Filters;

public sealed class ValidationFilter<TEntity> : IEndpointFilter where TEntity : class
{
    private readonly IValidator<TEntity> _validator;

    public ValidationFilter(IValidator<TEntity> validator)
    {
        _validator = validator;
    }

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        if (context.Arguments.FirstOrDefault(x => x is TEntity) is not TEntity typedEntity) 
            return TypedResults.BadRequest("Request data is not found");
        
        var result = await _validator.ValidateAsync(typedEntity);
        return result.IsValid
            ? await next(context)
            : TypedResults.BadRequest(string.Join('\n', result.Errors.Select(x => x.ErrorMessage)));
    }
}