using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Student
{
    [Key]
    public int Student_ID { get; set; }
    [Required]
    public required string Name { get; set; }
    public int Year { get; set; }
    [Required]
    public required string Email { get; set; }
}
