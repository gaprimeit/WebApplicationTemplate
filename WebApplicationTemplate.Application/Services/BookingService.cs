using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Interfaces;

namespace WebApplicationTemplate.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<BookingDto> CreateBookingAsync(BookingDto booking)
        {
            if (!booking.Passengers.Any(p => p.Type == "ADT"))
                throw new Exception("Debe haber al menos un adulto.");

            if (booking.Flight.Date < DateTime.Now)
                throw new Exception("No se puede reservar un vuelo ya volado.");

            booking.BookingId = GenerateBookingId();
            booking.TotalPrice = CalculateTotalPrice(booking);

            await _repository.AddBookingAsync(booking);
            return booking;
        }

        public async Task<BookingDto?> GetBookingAsync(string bookingId)
        {
            return await _repository.GetBookingAsync(bookingId);
        }

        private string GenerateBookingId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        private decimal CalculateTotalPrice(BookingDto booking)
        {
            decimal total = 0;
            foreach (var p in booking.Passengers)
            {
                total += p.Type == "ADT" ? booking.Flight.Price : booking.Flight.Price * 0.5m;
            }
            return Math.Round(total, 2);
        }
    }
}