using WebApplicationTemplate.Application.DTOs;

namespace WebApplicationTemplate.Application.Interfaces
{
    public interface IBookingRepository
    {
        Task AddBookingAsync(BookingDto booking);
        Task<BookingDto?> GetBookingAsync(string bookingId);
    }
}
