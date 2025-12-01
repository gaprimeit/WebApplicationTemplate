using Microsoft.AspNetCore.Mvc;
using WebApplicationTemplate.API.DTOs;
using WebApplicationTemplate.API.Mappers;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.API.Controllers.V1
{
    /// <summary>
    ///
    /// </summary>
    //[Authorize]
    [ApiVersion("1.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fooService"></param>

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fooService"></param>

        [HttpGet]
        public async Task<IActionResult> GetFlights([FromQuery] FlightRqDto request)
        {
            var flights = await _flightService.GetFlightsAsync(request.Date, request.Origin, request.Destination, request.Adults, request.Children);
            return Ok(flights.Select(f => f.ToApi()));
        }
    }
}
