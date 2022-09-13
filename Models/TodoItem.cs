using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class TodoItem
{
    public TodoItem()
    {
        
    }
    public TodoItem(int project_id, string name, string description)
    {
        ProjectId = project_id;
        Name = name;
        Description = description;
        Status = "In Progress";
    }
    [Key]
    public int id {get; set;}
    [Column("project_id")]
    public int ProjectId {get; set;}
    [Column("name")]
    public string Name {get; set;}
    [Column("description")]
    public string Description {get; set;}
    [Column("status")]
    public string Status {get; set;}
}