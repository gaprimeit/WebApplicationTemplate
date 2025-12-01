namespace WebApplicationTemplate.Application.DTOs
{
    public class FlightDto
    {
        public string FlightNumber { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
