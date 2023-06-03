namespace TravelAgents.Contracts.Destination;

public record DestinationResponse(
    Guid Id,
    string City,
    string Country,
    float Rating,
    string Description,
    float BasePrice
);