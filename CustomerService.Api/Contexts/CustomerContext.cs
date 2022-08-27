namespace CustomerService.Api.Contexts;

public sealed class CustomerContext : DbContext
{
    public DbSet<Domain.Customer> Customers => Set<Domain.Customer>();

    public CustomerContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
}