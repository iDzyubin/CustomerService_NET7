namespace CustomerService.Api.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile() => 
        CreateMap<Models.Customer, Domain.Customer>().ReverseMap();
}