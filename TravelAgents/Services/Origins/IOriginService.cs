using ErrorOr;
using TravelAgents.Contracts.Origin;
using TravelAgents.Models;

namespace TravelAgents.Services.Origins;

public interface IOriginService
{
    void CreateOrigin(Origin request);
    ErrorOr<Origin> GetOrigin(Guid id);
    void UpsertOrigin(Guid id, Origin request);
    void DeleteOrigin(Guid id);
}