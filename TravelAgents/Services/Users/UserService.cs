using TravelAgents.Models;

namespace TravelAgents.Services.Users;

public class UserService : IUserService
{
    private static Dictionary<Guid, User> _users = new();
    public void DeleteUser(Guid id)
    {
        _users.Remove(id);
    }

    public User GetUser(Guid id)
    {
        return _users[id];
    }

    public User UpdateUser(Guid id, User user)
    {
        _users[id] = user;
        return _users[id];
    }
}
