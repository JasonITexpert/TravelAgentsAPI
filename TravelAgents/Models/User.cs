namespace TravelAgents.Models;

public class User
{
    public Guid Id { get; }
    public string Username { get; }
    public string FirstName { get; }
    public string PasswordHash { get; }
    public string PasswordSalt { get; }
    public DateTime LastDateModifiedDateTime { get; }
    public DateTime CreatedDateTime { get; }
    public User(
        Guid id,
        string username,
        string firstName,
        string lastName
    )
    {

    }
}