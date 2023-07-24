using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgents.Controllers;

[Route("[controller]")]
[Authorize(Roles = "User")]
public class TestController : ControllerBase
{
    public IActionResult GetString()
    {
        return Ok("It is working");
    }
}