namespace TravelAgents.Contracts.User;

public record UpdateUserRequest(
    string Username,
    string FirstName,
    int Age,
    string LastName,
    string Email,
    DateTime DateOfBirth
);