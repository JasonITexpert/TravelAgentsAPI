using TravelAgents.Contracts.Destination;
using TravelAgents.Contracts.Origin;

namespace TravelAgents.Contracts;

public record BookingResponse(
    Guid Id,
    float FinalCost,
    OriginResponse Origin,
    DestinationResponse Destination,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime,
    DateTime DepartureDateTime,
    DateTime ArrivalDateTime
);