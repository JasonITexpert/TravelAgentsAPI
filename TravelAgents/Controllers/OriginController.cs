using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts;
using TravelAgents.Contracts.Origin;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class OriginController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateOrigin(CreateOriginRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetOrigin(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertOrigin(Guid id, UpsertOriginRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteOrigin(Guid id)
    {
        return NoContent();
    }
}