using WebApplicationTemplate.Domain.ValueObjects;

namespace WebApplicationTemplate.Domain.Entities
{
    public class Booking
    {
        public string BookingId { get; set; }
        public Flight Flight { get; set; }
        public List<Passenger> Passengers { get; set; } = new();
        public Contact Contact { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
