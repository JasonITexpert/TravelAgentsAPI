namespace TravelAgents.Contracts.Origin;

public record UpsertOriginRequest(
    string Country,
    string City,
    float Price
);
