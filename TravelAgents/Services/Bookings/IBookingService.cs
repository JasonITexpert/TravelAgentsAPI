using TravelAgents.Contracts;
using TravelAgents.Models;

namespace TravelAgents.Services.Bookings;

public interface IBookingService
{
    void CreateBooking(Booking request);
    Booking UpsertBooking(Guid id, Booking request);
    Booking GetBooking(Guid id);
    void DeleteBooking(Guid id);
}