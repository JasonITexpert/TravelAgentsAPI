namespace TravelAgents.Contracts;

public record CreateBookingRequest(
    float InitialCost,
    float Discount,
    float FinalCost,
    Guid OriginId,
    Guid DestinationId,
    DateTime DepartureDateTime,
    DateTime ArrivalDateTime
);