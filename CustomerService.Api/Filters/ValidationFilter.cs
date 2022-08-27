namespace CustomerService.Api.Filters;

public class ValidationEndpointFilter : IEndpointFilter
{
    public ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        throw new NotImplementedException();
    }
}