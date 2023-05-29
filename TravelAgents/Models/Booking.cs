namespace TravelAgents.Models;

public class Booking
{
    public Guid Id { get; }
    public DateTime CreatedDateTime { get; }
    public float InitialCost { get; }
    public float Discount { get; }
    public float FinalCost { get; }
    public Origin Origin { get; }
    public Guid OriginId { get; }
    public Destination Destination { get; }
    public Guid DestinationId { get; }
    public float FinalPrice { get; set; }

    public Booking
    (
        Guid id,
        DateTime createdDateTime,
        float initialCost,
        float discount,
        float finalCost,
        Trip Trip
    )
    {
        //enforce variants
        Id = id;
        CreatedDateTime = createdDateTime;
        InitialCost = initialCost;
        Discount = discount;
        FinalCost = finalCost;
        Origin = Trip.Origin;
        OriginId = Trip.Origin.Id;
        Destination = Trip.Destination;
        DestinationId = Trip.Destination.Id;

    }
}