namespace TravelAgents.Contracts.Destination;

public record UpsertDestinationRequest(
    string City,
    string Country,
    float Rating,
    float BasePrice,
    string Description
);