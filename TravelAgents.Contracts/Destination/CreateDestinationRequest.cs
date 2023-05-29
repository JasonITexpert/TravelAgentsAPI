namespace TravelAgents.Contracts.Destination;

public record CreateDestinationRequest(
    string Country,
    string City,
    float Price,
    string Description
);