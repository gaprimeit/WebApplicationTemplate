namespace WebApplicationTemplate.API.DTOs
{
    public class BookingRsDto
    {
        public string BookingId { get; set; } = string.Empty;
        public FlightRsDto Flight { get; set; } = new FlightRsDto();
        public List<BookingPassengerRsDto> Passengers { get; set; } = new();
        public BookingContactRsDto Contact { get; set; } = new();
        public decimal TotalPrice { get; set; }
    }

    public class BookingPassengerRsDto
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    public class BookingContactRsDto
    {
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
