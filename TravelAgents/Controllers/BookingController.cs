using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts;
using TravelAgents.Contracts.Destination;
using TravelAgents.Contracts.Origin;
using TravelAgents.Models;
using TravelAgents.Services.Bookings;
using TravelAgents.Services.Destinations;
using TravelAgents.Services.Origins;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;
    private readonly IOriginService _originService;
    private readonly IDestinationService _destinationService;
    public BookingController(IBookingService bookingService, IOriginService originService, IDestinationService destinationService)
    {
        //dependency injections
        _bookingService = bookingService;
        _originService = originService;
        _destinationService = destinationService;
    }
    [HttpPost]
    public IActionResult CreateBooking(CreateBookingRequest request)
    {//request contract to api model
        var booking = new Booking(
            Guid.NewGuid(),
            request.InitialCost,
            request.Discount,
            request.FinalCost,
            DateTime.UtcNow,
            DateTime.UtcNow,
            request.OriginId,
            request.DestinationId,
            request.DepartureDateTime,
            request.ArrivalDateTime
        );
        //for testing purpose getting mapping booking obj origin using origin service
        var origin = _originService.GetOrigin(booking.OriginId);
        var originResponse = new OriginResponse(
            origin.Id,
            origin.Country,
            origin.City,
            origin.Price,
            origin.CreatedDateTime,
            origin.LastModifiedDateTime);

        //for testing purpose getting mapping booking obj origin using origin service
        var destination = _destinationService.GetDestination(booking.DestinationId);
        var destinationResponse = new DestinationResponse(
            destination.Id,
            destination.City,
            destination.Country,
            destination.Rating,
            destination.Description,
            destination.BasePrice);

        booking.Origin = origin;
        booking.Destination = destination;
        //TODO: PERSITENCE (save to db)
        _bookingService.CreateBooking(booking);
        //api model to response
        var response = new BookingResponse(
            booking.Id,
            booking.FinalCost,
            originResponse,
            destinationResponse,
            booking.CreatedDateTime,
            DateTime.UtcNow,
            booking.DepartureDateTime,
            booking.ArrivalDateTime
);
        return CreatedAtAction(
            actionName: nameof(GetBooking),
            routeValues: new { id = booking.Id },
            value: response
        );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBooking(Guid id)
    {

        var booking = _bookingService.GetBooking(id);
        //for testing purpose getting mapping booking obj origin using origin service
        var origin = _originService.GetOrigin(booking.OriginId);
        var originResponse = new OriginResponse(
            origin.Id,
            origin.Country,
            origin.City,
            origin.Price,
            origin.CreatedDateTime,
            origin.LastModifiedDateTime);

        //for testing purpose getting mapping booking obj origin using origin service
        var destination = _destinationService.GetDestination(booking.DestinationId);
        var destinationResponse = new DestinationResponse(
            destination.Id,
            destination.City,
            destination.Country,
            destination.Rating,
            destination.Description,
            destination.BasePrice);
        //api model to response 
        var response = new BookingResponse(
            booking.Id,
            booking.FinalCost,
            originResponse,
            destinationResponse,
            booking.CreatedDateTime,
            DateTime.UtcNow,
            booking.DepartureDateTime,
            booking.ArrivalDateTime
        );
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBooking(Guid id, UpsertBookingRequest request)
    {
        var booked = _bookingService.GetBooking(id);
        //request to api model
        var booking = new Booking(
            id,
            request.InitialCost,
            request.Discount,
            request.FinalCost,
            booked.CreatedDateTime,
            DateTime.UtcNow,
            request.OriginId,
            request.DestinationId,
            request.DepartureDateTime,
            request.ArrivalDateTime
        );
        _bookingService.UpsertBooking(id, booking);
        //Return 201 if a new breakfast was created.

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBooking(Guid id)
    {
        _bookingService.DeleteBooking(id);
        return NoContent();
    }
}