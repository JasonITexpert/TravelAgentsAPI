using TravelAgents.Contracts.Origin;
using TravelAgents.Models;

namespace TravelAgents.Services.Origins;

public class OriginService : IOriginService
{
    //for crud testing. delete when done
    public static Dictionary<Guid, Origin> _origins = new();
    public void CreateOrigin(Origin request)
    {
        _origins.Add(request.Id, request);
    }

    public void DeleteOrigin(Guid id)
    {
        _origins.Remove(id);
    }

    public Origin GetOrigin(Guid id)
    {
        return _origins[id];
    }

    public void UpsertOrigin(Guid id, Origin request)
    {
        _origins[id] = request;
    }
}