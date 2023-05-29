namespace TravelAgents.Contracts.Destination;

public record DestinationResponse(
    Guid Id,
    string City,
    string County,
    float Rating,
    string Destination,
    float BasePrice
);