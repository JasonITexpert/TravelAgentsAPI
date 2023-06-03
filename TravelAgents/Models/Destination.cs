namespace TravelAgents.Models;

public class Destination
{
    public Guid Id { get; }
    public string City { get; }
    public string Country { get; }
    public float Rating { get; }
    public string Description { get; }
    public float BasePrice { get; }
    public Destination(
        Guid id,
        string city,
        string country,
        float rating,
        string description,
        float basePrice
    )
    {
        //enforce variants
        Id = id;
        City = city;
        Country = country;
        Rating = rating;
        Description = description;
        BasePrice = basePrice;

    }
}