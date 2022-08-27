using System.ComponentModel.DataAnnotations;

namespace CustomerService.Api.Domain;

public class Customer
{
    [Key]
    public long Id { get; set; }
    
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public int Age { get; set; }
}