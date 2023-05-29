using Microsoft.AspNetCore.Mvc;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class DestinationController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateDestination()
    {
        return Ok();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetDestination(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertDestination(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteDestination(Guid id)
    {
        return Ok(id);
    }
}