using TravelAgents.Contracts;
using TravelAgents.Models;

namespace TravelAgents.Services.Bookings;

public class BookingService : IBookingService
{
    public static Dictionary<Guid, Booking> _bookings = new();
    public void CreateBooking(Booking booking)
    {
        _bookings.Add(booking.Id, booking);
    }

    public Booking GetBooking(Guid id)
    {
        return _bookings[id];
    }

    public Booking UpsertBooking(Guid id, Booking booking)
    {
        _bookings[booking.Id] = booking;
        return _bookings[id];
    }

    public void DeleteBooking(Guid id)
    {
        _bookings.Remove(id);
    }
}
