using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TimeTable
{
    [Key]
    public int id {get; set;}
    [Column("start_time")]
    public DateTime StartTime {get; set;}
    [Column("end_time")]

    public DateTime EndTime {get; set;}
    [Column("project_id")]

    public int ProjectId {get; set;}
}