namespace TravelAgents.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string Username,
    string FirstName,
    string LastName,
    string Email,
    string token
);