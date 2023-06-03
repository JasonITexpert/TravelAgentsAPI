namespace TravelAgents.Models;

public class Trip
{
    public Guid Id { get; set; }
    public Destination Destination { get; set; }
    public Origin Origin { get; set; }
    public Trip(Guid OriginId, Guid DestinationId)
    {

    }
}