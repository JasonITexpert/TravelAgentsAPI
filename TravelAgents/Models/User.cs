namespace TravelAgents.Models;

public class User
{
    public Guid Id { get; }
    public string Username { get; }
    public string FirstName { get; }
    public string Email { get; }
    public string LastName { get; }
    public string PasswordHash { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastDateModifiedDateTime { get; }
    public List<Booking>? Bookings { get; set; }

    public User(
        Guid id,
        string userName,
        string firstName,
        string lastName,
        string passwordHash,
        DateTime createdDateTime,
        DateTime lastModifiedDateTime,
        List<Booking>? bookings
        )
    {
        Id = id;
        Username = userName;
        FirstName = firstName;
        LastName = lastName;
        PasswordHash = passwordHash;
        CreatedDateTime = createdDateTime;
        LastDateModifiedDateTime = lastModifiedDateTime;
        Bookings = bookings;
    }

}