namespace TravelAgents.Contracts;

public record CreateUserRequest(
    string Username,
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string ConfirmPassword,
    DateTime DateOfBirth
);