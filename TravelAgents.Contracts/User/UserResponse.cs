namespace TravelAgents.Contracts.User;

public record UserResponse(
    Guid Id,
    string FirstName,
    string LastName,
    int Age,
    string Username,
    string NormalizedUserName,
    string Email,
    string NormalizedEmail,
    bool EmailConfirmed,
    string PasswordHash,
    string passwordSalt,
    DateTime CreatedDateTime,
    DateTime LastModifiedDateTime,
    string SecurityStamp,
    Guid ConcurrencyStamp,
    string PhoneNumber,
    bool PhoneNumberConfirmed,
    bool TwoFactorEnabled,
    DateTimeOffset LockoutEnd,
    bool LockoutEnabled,
    int AccessFailedCount
    );