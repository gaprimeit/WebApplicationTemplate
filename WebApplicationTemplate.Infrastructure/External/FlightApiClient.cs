using System.Net.Http.Json;
using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.Infrastructure.External
{
    public class FlightApiClient : IFlightRepository
    {
        private readonly HttpClient _http;

        public FlightApiClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<FlightDto>> GetAllFlightsAsync()
        {
            var flights = await _http.GetFromJsonAsync<List<FlightDto>>(
                "https://otd-exams-data.vueling.app/cheap-flights/flight-rs-2.json");

            return flights ?? new List<FlightDto>();
        }
    }
}