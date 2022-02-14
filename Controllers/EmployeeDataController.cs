using Microsoft.AspNetCore.Mvc;
using RestApiExercise.DataAccessLayer;

namespace RestApiExercise.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeDataController : ControllerBase
{
    private readonly ILogger<EmployeeDataController> _logger;

    public EmployeeDataController(ILogger<EmployeeDataController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public EmployeeDbEntity Get(int employeeId)
    {
        var mgr = new EmployeeManager();
        return mgr.GetEmployee(employeeId);
    }

    [HttpPost(Name = "DeleteEmployee")]
    public void Delete(int employeeId)
    {
        var mgr = new EmployeeManager();
        mgr.Delete(employeeId);
    }
}