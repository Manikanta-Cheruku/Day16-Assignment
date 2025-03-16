using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
public class UserLogin
{
    [Key]  // Define primary key
    public int Id { get; set; }
    
    public string? Username { get; set; }
    public string? Password { get; set; }
}

}
