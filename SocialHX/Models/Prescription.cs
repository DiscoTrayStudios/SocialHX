using System.ComponentModel.DataAnnotations;

namespace SocialHX.Models;

public enum Status
{
    Active, Complete, Archived
}


public class Prescription
{
    [Key]
    public int Case_Number { get; set; }
    public int Student_ID { get; set; }
    public int Prescriber_ID { get; set; }

    public DateTime Date_Time { get; set; }
    public int Event1_ID { get; set; }
    public int Event2_ID { get; set; }
    public int Event3_ID { get; set; }
    public int Event4_ID { get; set; }

    public int Follow_Up_ID { get; set; }
    public int Follow_Up_Refill_ID { get; set; }

    public Status Status { get; set; }





}