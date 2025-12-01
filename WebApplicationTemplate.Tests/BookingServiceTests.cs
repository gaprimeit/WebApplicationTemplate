using Moq;
using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Interfaces;
using WebApplicationTemplate.Application.Services;

namespace WebApplicationTemplate.Tests
{
    public class BookingServiceTests
    {
        [Fact]
        public async Task AddBookingAsync_CallsRepository()
        {
            // Arrange
            var mockRepo = new Mock<IBookingRepository>();
            var service = new BookingService(mockRepo.Object);

            var booking = new BookingDto
            {
                BookingId = "ABC123",
                Flight = new FlightDto
                {
                    FlightNumber = "A1",
                    Origin = "BCN",
                    Destination = "MAD",
                    Date = System.DateTime.Now,
                    Price = 100
                },
                Passengers = new System.Collections.Generic.List<PassengerDto>
            {
                new PassengerDto { Name = "John Doe", Type = "ADT", Age = 25 }
            },
                ContactEmail = "test@example.com",
                ContactPhone = "1234567890",
                TotalPrice = 100
            };

            // Act
            await service.CreateBookingAsync(booking);

            // Assert
            mockRepo.Verify(r => r.AddBookingAsync(It.Is<BookingDto>(b => b.BookingId == "ABC123")), Times.Once);
        }
    }
    
}