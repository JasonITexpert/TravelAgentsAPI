using TravelAgents.Models;

namespace TravelAgents.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    private static List<User> _users = new();
    public AuthenticationResult Register(string username, string firstName, string lastName, string email, string password, DateOnly DateOfBirth)
    {
        //Check if user already exists
        bool userExists;
        var existingUser = _users.Find(user => user.Email == email);
        if (existingUser is not null)
        {
            userExists = true;
            return null;
        }

        //Create User 
        //Generate Token
        Guid userId = Guid.NewGuid();
        // hash password
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

        AuthenticationResult authResult = new AuthenticationResult(
           userId,
           username,
           firstName,
           lastName,
           email,
           null);

        User user = new User(
            authResult.Id,
            authResult.Username,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            null,
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
        //for testing purposes, to be replaced by entity framework ORM
        var user = _users.Find(user => user.Username == userName);
        if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        {
            var token = _jwtTokenGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);
            var authResult = new AuthenticationResult(
                user.Id,
                user.Username,
                user.FirstName,
                user.LastName,
                user.Email,
                token);
            return authResult;
        }
        return null;
    }
}