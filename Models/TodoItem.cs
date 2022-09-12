using System.ComponentModel.DataAnnotations;
public class TodoItem
{
    public TodoItem()
    {
        
    }
    public TodoItem(int _project_id, string _name, string _description)
    {
        project_id = _project_id;
        name = _name;
        description = _description;
        status = "In Progress";
    }
    [Key]
    public int id {get; set;}
    public int project_id {get; set;}
    public string name {get; set;}
    public string description {get; set;}
    public string status {get; set;}
}