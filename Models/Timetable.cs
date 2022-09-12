using System.ComponentModel.DataAnnotations;
public class TimeTable
{
    [Key]
    public int id {get; set;}
    public DateTime start_time {get; set;}
    public DateTime end_time {get; set;}
    public int project_id {get; set;}
}