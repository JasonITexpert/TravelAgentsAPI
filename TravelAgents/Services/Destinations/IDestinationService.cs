using TravelAgents.Contracts.Destination;
using TravelAgents.Models;

namespace TravelAgents.Services.Destinations;

public interface IDestinationService
{
    void CreateDestination(Destination request);
    Destination GetDestination(Guid id);
    Destination UpsertDestination(Guid id, Destination request);
    void DeleteDestination(Guid id);
}