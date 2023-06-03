using Microsoft.EntityFrameworkCore;
using TravelAgents.Models;

namespace TravelAgents.Persistence;

public class TravelAgentsDbContext : DbContext
{
    public TravelAgentsDbContext(DbContextOptions<TravelAgentsDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Origin> Origins { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Trip> Trips { get; set; }
}