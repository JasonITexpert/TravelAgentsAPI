using Microsoft.AspNetCore.Mvc;

namespace TravelAgents.Controllers;

[ApiController]
[Route("/error")]
public class ErrorsController : ControllerBase
{
    public IActionResult Error()
    {
        return Problem();
    }

}