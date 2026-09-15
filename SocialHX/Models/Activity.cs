using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Activity
{
    [Key]
    public int Event_ID { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Description { get; set; }
    public DateTime DateTime { get; set; }
    [Required]
    public required string Location { get; set; }

}