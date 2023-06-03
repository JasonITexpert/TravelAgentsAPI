using TravelAgents.Models;

namespace TravelAgents.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string username, string firstName, string lastName, string email, string password, DateOnly DateOfBirth)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            username,
            firstName,
            lastName,
            email);
    }

    public AuthenticationResult Login(string userName, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            userName,
            "firstName",
            "lastName",
            "email");
    }
}