namespace TravelAgents.Contracts;

public record CreateBookingRequest(
    // Guid UserId,
    Guid DestinationId,
    DateTime CreatedDateTime,
    float InitialCost,
    float Discount,
    float FinalCost
);