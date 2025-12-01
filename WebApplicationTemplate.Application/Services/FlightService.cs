using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.Application.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _repository;

        public FlightService(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<FlightDto>> GetFlightsAsync(DateTime date, string origin, string? destination, int adults, int children)
        {
            var allFlights = await _repository.GetAllFlightsAsync();

            var filtered = allFlights
                .Where(f => f.Date.Date == date.Date && f.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(destination))
                filtered = filtered.Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase));

            return filtered.OrderBy(f => f.Price).ToList();
        }
    }
}