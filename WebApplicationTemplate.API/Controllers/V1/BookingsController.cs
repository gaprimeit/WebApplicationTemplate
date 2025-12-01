using Microsoft.AspNetCore.Mvc;
using WebApplicationTemplate.API.DTOs;
using WebApplicationTemplate.API.Mappers;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.API.Controllers.V1
{
    /// <summary>
    ///
    /// </summary>
    [ApiVersion("1.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fooService"></param>

        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] BookingRqDto request)
        {
            var bookingDto = request.ToApplication();
            var result = await _bookingService.CreateBookingAsync(bookingDto);
            return Ok(result.ToApi());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fooService"></param>

        [HttpGet("{bookingId}")]
        public async Task<IActionResult> GetBooking(string bookingId)
        {
            var booking = await _bookingService.GetBookingAsync(bookingId);
            if (booking == null) return NotFound();
            return Ok(booking.ToApi());
        }
    }
}
