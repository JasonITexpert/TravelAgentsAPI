namespace TravelAgents.Models;

public class Destination
{
    public Guid Id { get; }
    public string City { get; }
    public string Country { get; }
    public float Rating { get; }
    public string Description { get; }
    public float BasePrice { get; }
}