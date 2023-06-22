using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts;
using TravelAgents.Contracts.Origin;
using TravelAgents.Models;
using TravelAgents.Services.Origins;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
// [Authorize(Roles = "Admin")]
public class OriginController : ControllerBase
{
    private readonly IOriginService _originService;
    public OriginController(IOriginService originService)
    {//dependecy injection
        _originService = originService;
    }
    [HttpPost]
    public IActionResult CreateOrigin(CreateOriginRequest request)
    {
        //request to api model
        var origin = new Origin(
            Guid.NewGuid(),
            request.Country,
            request.City,
            request.Price,
            DateTime.UtcNow,
            DateTime.UtcNow);

        //TODO: save user to db
        //For testing purposes
        _originService.CreateOrigin(origin);
        //api model to response
        var response = new OriginResponse(
            origin.Id,
            origin.Country,
            origin.City,
            origin.Price,
            origin.CreatedDateTime,
            origin.LastModifiedDateTime);
        return CreatedAtAction(
            actionName: nameof(GetOrigin),
            routeValues: new { id = origin.Id },
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetOrigin(Guid id)
    {
        var origin = _originService.GetOrigin(id);
        //api model to response
        var response = new OriginResponse(
            origin.Id,
            origin.Country,
            origin.City,
            origin.Price,
            origin.CreatedDateTime,
            origin.LastModifiedDateTime);
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertOrigin(Guid id, UpsertOriginRequest request)
    {
        var currentOrigin = _originService.GetOrigin(id);
        //request to api model
        var origin = new Origin(
            id,
            request.Country,
            request.City,
            request.Price,
            currentOrigin.CreatedDateTime,
            DateTime.UtcNow);
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteOrigin(Guid id)
    {
        _originService.DeleteOrigin(id);
        return NoContent();
    }
}