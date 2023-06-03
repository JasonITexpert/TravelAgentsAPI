namespace TravelAgents.Models;

public class Booking
{
    public Guid Id { get; }
    public float InitialCost { get; }
    public float Discount { get; }
    public float FinalCost { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public Origin Origin { get; set; }
    public Guid OriginId { get; }
    public Destination Destination { get; set; }
    public Guid DestinationId { get; }
    public DateTime DepartureDateTime { get; }
    public DateTime ArrivalDateTime { get; }

    public Booking
    (
        Guid id,
        float initialCost,
        float discount,
        float finalCost,
        DateTime createdDateTime,
        DateTime lastModifiedDateTime,
        Guid originId,
        Guid destinationId,
        DateTime departureDateTime,
        DateTime arrivalDateTime
    )
    {
        //enforce variants
        Id = id;
        InitialCost = initialCost;
        Discount = discount;
        FinalCost = finalCost;
        CreatedDateTime = createdDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        OriginId = originId;
        DestinationId = destinationId;
        DepartureDateTime = departureDateTime;
        ArrivalDateTime = arrivalDateTime;
    }
}