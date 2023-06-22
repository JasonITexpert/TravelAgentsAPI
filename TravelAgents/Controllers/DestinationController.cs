using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts.Destination;
using TravelAgents.Models;
using TravelAgents.Services.Destinations;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
// [Authorize(Roles = "Admin")]
public class DestinationController : ControllerBase
{
    private readonly IDestinationService _destinationService;
    public DestinationController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }
    [HttpPost]
    public IActionResult CreateDestination(CreateDestinationRequest request)
    {
        //request to api model
        var destination = new Destination(
            Guid.NewGuid(),
            request.City,
            request.Country,
            request.Rating,
            request.Description,
            request.BasePrice
        );
        //TODO : Add to database

        //Code line below is for testing purposes
        _destinationService.CreateDestination(destination);
        //api model to response
        var response = new DestinationResponse(
            destination.Id,
            destination.City,
            destination.Country,
            destination.Rating,
            destination.Description,
            destination.BasePrice
            );
        //return 201 Created
        return CreatedAtAction(
            actionName: nameof(CreateDestination),
            routeValues: new { id = destination.Id },
            value: response
        );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetDestination(Guid id)
    {
        var destination = _destinationService.GetDestination(id);
        //api model to response
        var response = new DestinationResponse(
            destination.Id,
            destination.City,
            destination.Country,
            destination.Rating,
            destination.Description,
            destination.BasePrice);
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertDestination(Guid id, UpsertDestinationRequest request)
    {
        var currentDestination = _destinationService.GetDestination(id);
        //request to api moel 
        var destination = new Destination(
            id,
            request.City,
            request.Country,
            request.Rating,
            request.Description,
            request.BasePrice);

        _destinationService.UpsertDestination(id, destination);

        //api model to response
        var response = new DestinationResponse(
            destination.Id,
            destination.City,
            destination.Country,
            destination.Rating,
            destination.Description,
            destination.BasePrice);
        return Ok(response);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteDestination(Guid id)
    {
        _destinationService.DeleteDestination(id);
        return NoContent();
    }
}