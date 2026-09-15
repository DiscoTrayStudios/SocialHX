using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Prescriber
{
    [Key]
    public int Prescriber_ID { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Department { get; set; }
    [Required]
    public required string Location { get; set; }


}