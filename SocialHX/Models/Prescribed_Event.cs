using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Prescribed_Event
{
    [Key]
    public int Prescribed_Event_ID { get; set; }
    [Required]
    public required string Notes { get; set; }
    [Required]
    public required string Other_Person { get; set; }
    public int Event_ID { get; set; }
}