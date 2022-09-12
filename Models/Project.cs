using System.Collections.Generic;
public class Project 
{
    public Project()
    {

    }
    public Project(string _name)
    {
        name = _name;
    }
    public int id {get; set;}
    public int progress {get; set;}
    public int streak {get; set;}
    public string? name {get; set;}
    TodoItem? chore {get; set;}
    public List<TodoItem>? TodoList {get; set;}
}
