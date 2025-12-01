using WebApplicationTemplate.Application.DTOs;

namespace WebApplicationTemplate.Application.Interfaces
{
    public interface IBookingService
    {
        Task<BookingDto> CreateBookingAsync(BookingDto bookingRequest);
        Task<BookingDto?> GetBookingAsync(string bookingId);
    }
}