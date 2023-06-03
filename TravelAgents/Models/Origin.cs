namespace TravelAgents.Models;

public class Origin
{
    public Guid Id { get; }
    public string Country { get; }
    public string City { get; }
    public float Price { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public Origin(
        Guid id,
        string country,
        string city,
        float price,
        DateTime createdDateTime,
        DateTime lastModifiedDateTime
    )
    {
        //enforce variants
        Id = id;
        Country = country;
        City = city;
        Price = price;
        CreatedDateTime = createdDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
    }
}