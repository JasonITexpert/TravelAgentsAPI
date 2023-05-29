namespace TravelAgents.Models;

public class Origin
{
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public float Price { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime LastModifiedDateTime { get; set; }
}