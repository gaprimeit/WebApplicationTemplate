using WebApplicationTemplate.Application.DTOs;

namespace WebApplicationTemplate.Infrastructure.Repositories
{
    public class InMemoryDatabase
    {
        public List<BookingDto> Bookings { get; set; } = new List<BookingDto>();
    }
}
