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
    [Route("/api/datass")]
    public string GetProject(int id)
    {
        if(id == 1)
        return _Schedule_service.Datass();
        else
        return "nothing";
    }
    // public void GetProjects()
    // {

    // }
    // public void GetTodos()
    // {

    // }
    [HttpGet]
    [Route("/api/project")]
    public string GetTimelySchedule()
    {
        return _Schedule_service.GetCurrentProject();
    }
}
