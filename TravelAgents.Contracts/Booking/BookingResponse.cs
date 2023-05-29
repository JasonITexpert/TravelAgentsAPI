namespace TravelAgents.Contracts;

public record BookingResponse(
    Guid Id,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime,
    DateTime DepartureDateTime,
    DateTime ArrivalDateTime
);