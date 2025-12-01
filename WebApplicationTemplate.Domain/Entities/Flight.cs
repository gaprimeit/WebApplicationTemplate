namespace WebApplicationTemplate.Domain.Entities
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
