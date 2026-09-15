using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Follow_Up
{
    [Key]
    public int Follow_Up_ID { get; set; }
    public int Case_Number { get; set; }
    public Boolean Response { get; set; }
    [Required]
    public required string Student_Report { get; set; }
    [Required]
    public required string Student_Adjustments { get; set; }

}