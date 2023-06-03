using TravelAgents.Contracts.Destination;
using TravelAgents.Models;

namespace TravelAgents.Services.Destinations;

public class DestinationService : IDestinationService
{
    //for crud testing. delete when done
    public static Dictionary<Guid, Destination> _destinations = new();
    public void CreateDestination(Destination request)
    {
        _destinations.Add(request.Id, request);
    }

    public Destination GetDestination(Guid id)
    {
        return _destinations[id];
    }

    public Destination UpsertDestination(Guid id, Destination request)
    {
        _destinations[id] = request;
        return _destinations[id];
    }

    public void DeleteDestination(Guid id)
    {
        _destinations.Remove(id);
    }
}
