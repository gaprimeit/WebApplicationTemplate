using WebApplicationTemplate.API.DTOs;
using WebApplicationTemplate.Application.DTOs;

namespace WebApplicationTemplate.API.Mappers
{
    public static class FlightBookingMapper
    {
        public static FlightDto ToApplication(this FlightRsDto dto) => new()
        {
            FlightNumber = dto.FlightNumber,
            Origin = dto.Origin,
            Destination = dto.Destination,
            Date = dto.Date,
            Price = dto.Price
        };

        public static FlightRsDto ToApi(this FlightDto dto) => new()
        {
            FlightNumber = dto.FlightNumber,
            Origin = dto.Origin,
            Destination = dto.Destination,
            Date = dto.Date,
            Price = dto.Price
        };

        public static BookingDto ToApplication(this BookingRqDto dto)
        {
            return new BookingDto
            {
                Flight = dto.Flight.ToApplication(),
                Passengers = dto.Passengers.Select(p => new PassengerDto
                {
                    Name = p.Name,
                    Type = p.Type,
                    Age = p.Age
                }).ToList(),
                ContactEmail = dto.Contact.Email,
                ContactPhone = dto.Contact.Phone
            };
        }

        public static BookingRsDto ToApi(this BookingDto dto)
        {
            return new BookingRsDto
            {
                BookingId = dto.BookingId,
                Flight = dto.Flight.ToApi(),
                Passengers = dto.Passengers.Select(p => new BookingPassengerRsDto
                {
                    Name = p.Name,
                    Type = p.Type,
                    Age = p.Age
                }).ToList(),
                Contact = new BookingContactRsDto
                {
                    Email = dto.ContactEmail,
                    Phone = dto.ContactPhone
                },
                TotalPrice = dto.TotalPrice
            };
        }
    }
}
