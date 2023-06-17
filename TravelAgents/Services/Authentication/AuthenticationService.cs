using TravelAgents.Models;

namespace TravelAgents.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private static List<User> _users = new();
    public AuthenticationResult Register(string username, string firstName, string lastName, string email, string password, DateOnly DateOfBirth)
    {
        //Todo : hash password
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        AuthenticationResult authResult = new AuthenticationResult(
           Guid.NewGuid(),
           username,
           firstName,
           lastName,
           email
           );

        User user = new User(
            authResult.Id,
            authResult.Username,
            authResult.FirstName,
            authResult.LastName,
            passwordHash,
            DateTime.UtcNow,
            DateTime.UtcNow,
            null);

        //Persist User
        _users.Add(user);

        return authResult;
    }

    public AuthenticationResult Login(string userName, string password)
    {
        //for testing purposes, to be replace by entity framework ORM
        var user = _users.Find(user => user.Username == userName);
        if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        {
            var authResult = new AuthenticationResult(
                user.Id,
                user.Username,
                user.FirstName,
                user.LastName,
                user.Email);
            return authResult;
        }
        return null;
    }
}