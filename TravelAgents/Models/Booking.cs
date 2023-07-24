using TravelAgents.Services.Destinations;
using TravelAgents.Services.Origins;

namespace TravelAgents.Models;

public class Booking
{
    public Guid Id { get; }
    public float InitialCost { get; }
    public float Discount { get; }
    public float FinalCost { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public Origin Origin { get; }
    public Guid OriginId { get; }
    public Destination Destination { get; }
    public Guid DestinationId { get; }
    public DateTime DepartureDateTime { get; }
    public DateTime ArrivalDateTime { get; }

    private Booking
    (
        //TODO: confirm if sending the services to the api model's class is good code.
        IOriginService _originService,
        IDestinationService _destinationService,
        Guid id,
        float initialCost,
        float? discount,
        float finalCost,
        DateTime createdDateTime,
        DateTime lastModifiedDateTime,
        Guid originId,
        Guid destinationId,
        DateTime departureDateTime,
        DateTime arrivalDateTime
    )
    {
        // enforce variants
        // Id = id;
        // InitialCost = initialCost;
        // Discount = discount ?? 0;
        // FinalCost = finalCost;
        // CreatedDateTime = createdDateTime;
        // LastModifiedDateTime = lastModifiedDateTime;
        // OriginId = originId;
        // Origin = _originService.GetOrigin(OriginId);
        // DestinationId = destinationId;
        // Destination = _destinationService.GetDestination(DestinationId);
        // DepartureDateTime = departureDateTime;
        // ArrivalDateTime = arrivalDateTime;
    }

    public static Booking Create(
        IOriginService _originService,
        IDestinationService _destinationService,
        float initialCost,
        float discount,
        float finalCost,
        Guid originId,
        Guid destinationId,
        DateTime departureDateTime,
        DateTime arrivalDateTime,
        Guid? id = null
        )
    {
        return new Booking(
            _originService,
            _destinationService,
            Guid.NewGuid(),
            initialCost,
            discount,
            finalCost,
            DateTime.UtcNow,
            DateTime.UtcNow,
            originId,
            destinationId,
            departureDateTime,
            arrivalDateTime
        );
    }
}