using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Domain.Entities;

namespace WebApplicationTemplate.Application.Interfaces
{
    public interface IFlightService
    {
        /// <summary>
        /// Devuelve la lista de vuelos filtrados por fecha, origen, destino y número de pasajeros.
        /// Ordenados por precio ascendente.
        /// </summary>
        /// <param name="date">Fecha del vuelo</param>
        /// <param name="origin">Ciudad de origen</param>
        /// <param name="destination">Ciudad de destino (opcional)</param>
        /// <param name="adults">Número de adultos</param>
        /// <param name="children">Número de niños</param>
        /// <returns>Lista de FlightDto</returns>
        Task<List<FlightDto>> GetFlightsAsync(DateTime date, string origin, string? destination, int adults, int children);
    }

}
