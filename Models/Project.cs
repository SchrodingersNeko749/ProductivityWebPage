using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Project 
{
    public Project()
    {

    }
    public Project(string name)
    {
        Name = name;
    }
    [Key]
    public int id {get; set;}
    [Column("progress")]
    public int Progress {get; set;}
    [Column("streak")]
    public int Streak {get; set;}
    [Column("name")]
    public string? Name {get; set;}
    [Column("chore_id")]
    public int? ChoreId {get; set;}
}
