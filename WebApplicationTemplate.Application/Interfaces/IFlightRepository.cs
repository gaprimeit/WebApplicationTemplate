using WebApplicationTemplate.Application.DTOs;

namespace WebApplicationTemplate.Application.Interfaces
{
    public interface IFlightRepository
    {
        Task<List<FlightDto>> GetAllFlightsAsync();
    }
}