namespace WebApplicationTemplate.API.DTOs
{
    public class FlightRsDto
    {
        public string FlightNumber { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
