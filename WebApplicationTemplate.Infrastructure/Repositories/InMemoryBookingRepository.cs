using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.Infrastructure.Repositories
{
    public class InMemoryBookingRepository : IBookingRepository
    {
        private readonly List<BookingDto> _bookings = new();

        public Task AddBookingAsync(BookingDto booking)
        {
            _bookings.Add(booking);
            return Task.CompletedTask;
        }

        public Task<BookingDto?> GetBookingAsync(string bookingId)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == bookingId);
            return Task.FromResult(booking);
        }
    }
}