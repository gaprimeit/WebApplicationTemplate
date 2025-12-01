using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using WebApplicationTemplate.Application.Interfaces;
using WebApplicationTemplate.Application.DTOs;
using WebApplicationTemplate.Application.Services;
using Moq;

namespace WebApplicationTemplate.Tests
{
    public class FlightServiceTests
    {
        [Fact]
        public async Task GetFlightsAsync_FiltersByDateAndOrigin_ReturnsCorrectFlights()
        {
            // Arrange
            var mockRepo = new Mock<IFlightRepository>();
            mockRepo.Setup(r => r.GetAllFlightsAsync()).ReturnsAsync(new List<FlightDto>
            {
                new FlightDto { FlightNumber = "A1", Origin = "BCN", Destination = "MAD", Date = new DateTime(2025,12,01), Price = 100 },
                new FlightDto { FlightNumber = "A2", Origin = "BCN", Destination = "LON", Date = new DateTime(2025,12,01), Price = 150 },
                new FlightDto { FlightNumber = "B1", Origin = "MAD", Destination = "BCN", Date = new DateTime(2025,12,01), Price = 80 }
            });

            var service = new FlightService(mockRepo.Object);

            // Act
            var result = await service.GetFlightsAsync(new DateTime(2025, 12, 01), "BCN", null, 1, 0);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, f => Assert.Equal("BCN", f.Origin));
        }

        [Fact]
        public async Task GetFlightsAsync_FiltersByDestination_ReturnsCorrectFlight()
        {
            // Arrange
            var mockRepo = new Mock<IFlightRepository>();
            mockRepo.Setup(r => r.GetAllFlightsAsync()).ReturnsAsync(new List<FlightDto>
            {
                new FlightDto { FlightNumber = "A1", Origin = "BCN", Destination = "MAD", Date = new DateTime(2025,12,01), Price = 100 },
                new FlightDto { FlightNumber = "A2", Origin = "BCN", Destination = "LON", Date = new DateTime(2025,12,01), Price = 150 }
            });

            var service = new FlightService(mockRepo.Object);

            // Act
            var result = await service.GetFlightsAsync(new DateTime(2025, 12, 01), "BCN", "LON", 1, 0);

            // Assert
            Assert.Single(result);
            Assert.Equal("LON", result.First().Destination);
        }
    }
}
