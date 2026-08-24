using Microsoft.AspNetCore.Mvc;

namespace CSharpAIProject.Controllers;

[ApiController]
[Route("/testcase")]// ruote for local host API to go to
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "healthy"
        });
    }
}