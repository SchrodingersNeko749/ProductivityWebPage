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
        _logger.LogInformation("Schedule controller constructor");
    }
    [HttpGet]
    [Route("/api/project")]
    public Project GetProject(string time)
    {
       return _Schedule_service.GetCurrentProject(time);
    }
    // public void GetProjects()
    // {

    // }
    // public void GetTodos()
    // {

    // }
}
