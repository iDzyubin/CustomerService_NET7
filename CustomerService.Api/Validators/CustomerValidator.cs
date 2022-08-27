namespace CustomerService.Api.Validators;

public class CustomerValidator : AbstractValidator<Models.Customer>
{
    private const string RequiredMessage = "Field '{PropertyName}' cannot be empty";
    
    public CustomerValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage(RequiredMessage)
            .WithName("FirstName");
        
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage(RequiredMessage)
            .WithName("LastName");
        
        RuleFor(x => x.Age)
            .NotEmpty()
            .WithMessage(RequiredMessage)
            .WithName("Age");
    }
}