using TravelAgents.Models;

namespace TravelAgents.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string Username, string firstName, string lastName, string email, string password, DateOnly DateOfBirth);
    AuthenticationResult Login(string userName, string password);
}