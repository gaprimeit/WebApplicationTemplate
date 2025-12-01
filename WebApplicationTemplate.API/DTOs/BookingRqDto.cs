namespace WebApplicationTemplate.API.DTOs
{
    public class BookingRqDto
    {
        public FlightRsDto Flight { get; set; } = new FlightRsDto();
        public List<FlightPassengerDto> Passengers { get; set; } = new();
        public FlightContactDto Contact { get; set; } = new FlightContactDto();
    }

    public class FlightPassengerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    public class FlightContactDto
    {
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
