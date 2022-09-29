using Microsoft.AspNetCore.Mvc;
using ProductivityWebPage.Services;

namespace ProductivityWebPage.Controllers;

[ApiController]
[Route("[controller]")]
public class ScheduleController : ControllerBase
{   
    private ScheduleService _Schedule_service;
    private readonly ILogger<ScheduleController> _logger;

    public ScheduleController(ILogger<ScheduleController> logger)
    {
        _Schedule_service = new ScheduleService();
        _logger = logger;
    }
    [HttpGet]
    [Route("/api/currentProject")]
    public Project GetProject()
    {
       return _Schedule_service.GetCurrentProject();
    }
    [HttpGet]
    [Route("/api/projectTodo")]
    public TodoItem GetProjectTodo(int project_id)
    {
        return _Schedule_service.GetProjectTodoItem(project_id);
    }
    [HttpGet]
    [Route("/api/projectTodos")]
    public IQueryable<TodoItem> GetProjectTodos(int project_id)
    {
        return _Schedule_service.GetProjectTodoItems(project_id);
    }
    [HttpPost]
    [Route("/api/addTodo")]
    public IActionResult Addtodo([FromBody] TodoItem todo)
    {
        /*string name = "da";
        string description = "sa";*/
        _Schedule_service.AddTodo(new TodoItem(todo.ProjectId, todo.Name, todo.Description));
        return Ok();
    }
}
