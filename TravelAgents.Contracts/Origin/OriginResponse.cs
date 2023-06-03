namespace TravelAgents.Contracts.Origin;

public record OriginResponse(
    Guid Id,
    string Country,
    string City,
    float Price,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime
);