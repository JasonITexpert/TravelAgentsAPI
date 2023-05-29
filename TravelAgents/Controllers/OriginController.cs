using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class OriginController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBooking(CreateBookingRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBooking(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBooking(Guid id, UpsertBookingRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBooking(Guid id)
    {
        return NoContent();
    }
}