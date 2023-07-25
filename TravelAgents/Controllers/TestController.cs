using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgents.Controllers;


[Authorize(Roles = "User")]
public class TestController : ControllerBase
{
    public IActionResult GetString()
    {
        return Ok("It is working");
    }
}