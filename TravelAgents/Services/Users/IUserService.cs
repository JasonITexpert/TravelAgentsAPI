using TravelAgents.Models;

namespace TravelAgents.Services.Users;

public interface IUserService
{
    User UpdateUser(Guid id, User user);
    User GetUser(Guid id);
    void DeleteUser(Guid id);
}