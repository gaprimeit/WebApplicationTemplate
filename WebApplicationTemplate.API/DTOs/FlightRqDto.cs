namespace WebApplicationTemplate.API.DTOs
{
    public class FlightRqDto
    {
        public DateTime Date { get; set; }
        public string Origin { get; set; } = string.Empty;
        public string? Destination { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
    }
}
