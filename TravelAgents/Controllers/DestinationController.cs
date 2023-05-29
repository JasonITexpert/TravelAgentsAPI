using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts.Destination;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class DestinationController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateDestination(CreateDestinationRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetDestination(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertDestination(Guid id, UpsertDestinationRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteDestination(Guid id)
    {
        return NoContent();
    }
}