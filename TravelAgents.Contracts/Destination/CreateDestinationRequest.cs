namespace TravelAgents.Contracts.Destination;

public record CreateDestinationRequest(
    string Country,
    string City,
    float Rating,
    string Description,
    float BasePrice
);