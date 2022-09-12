using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Project 
{
    public Project()
    {

    }
    public Project(string _name)
    {
        name = _name;
    }
    [Key]
    public int id {get; set;}
    public int progress {get; set;}
    public int streak {get; set;}
    public string? name {get; set;}
    public int? chore_id {get; set;}
}
