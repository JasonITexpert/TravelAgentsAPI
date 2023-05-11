namespace TravelAgents.Models;

public class Booking
{
    public Guid Id { get; }
    public DateTime CreatedDateTime { get; }
    public float InitialCost { get; }
    public float Discount { get; }
    public float FinalCost { get; }
    public Destination Destination { get; }
    public Guid DestinationId { get; }
    public Booking
    (
        Guid id,
        DateTime createdDateTime,
        float initialCost,
        float discount,
        float finalCost,
        Destination destination,
        Guid destinationId
    )
    {
        //enforce variants
        Id = id;
        CreatedDateTime = createdDateTime;
        InitialCost = initialCost;
        Discount = discount;
        FinalCost = finalCost;
        Destination = destination;
        DestinationId = destinationId;
    }
}