namespace TravelAgents.Contracts.Origin;

public record CreateOriginRequest(
    string Country,
    string City,
    float Price
);