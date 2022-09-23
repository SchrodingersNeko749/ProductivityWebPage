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
    [HttpPut]
    [Route("/api/addTodo")]
    public void Addtodo(int project_id, string todoname, string tododescription)
    {
        _Schedule_service.AddTodo(project_id, todoname, tododescription);
    }
    // public void GetProjects()
    // {

    // }
    // public void GetTodos()
    // {

    // }
}
