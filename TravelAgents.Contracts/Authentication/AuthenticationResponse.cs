namespace TravelAgents.Contracts.Authentication;

public record AuthenticationResponse(
Guid Id,
string Username,
string FirstName,
string LastName,
string Email,
string? token);