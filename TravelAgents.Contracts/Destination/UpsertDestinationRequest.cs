namespace TravelAgents.Contracts.Destination;

public record UpsertDestinationRequest(
    string Country,
    string City,
    float Price,
    string Description
);