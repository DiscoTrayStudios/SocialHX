using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public class Follow_Up_Refill
{
    [Key]
    public int Follow_Up_Refill_ID { get; set; }
    public int Case_Number { get; set; }
    public Boolean Did_Meet { get; set; }
    public DateTime Date_Time { get; set; }
    public Boolean Did_Attend { get; set; }

    public int Events_Attended { get; set; }
    [Required]
    public required string Feelings { get; set; }
    [Required]
    public required string Barriers { get; set; }
    public Boolean Refill { get; set; }

}