namespace WebApplicationTemplate.Application.DTOs
{
    public class BookingDto
    {
        /// <summary>
        /// Identificador único de la reserva (6 caracteres alfanuméricos)
        /// </summary>
        public string BookingId { get; set; } = string.Empty;

        /// <summary>
        /// Información del vuelo reservado
        /// </summary>
        public FlightDto Flight { get; set; } = new FlightDto();

        /// <summary>
        /// Lista de pasajeros de la reserva
        /// </summary>
        public List<PassengerDto> Passengers { get; set; } = new List<PassengerDto>();

        /// <summary>
        /// Email de contacto de la reserva
        /// </summary>
        public string ContactEmail { get; set; } = string.Empty;

        /// <summary>
        /// Teléfono de contacto de la reserva
        /// </summary>
        public string ContactPhone { get; set; } = string.Empty;

        /// <summary>
        /// Precio total de la reserva
        /// </summary>
        public decimal TotalPrice { get; set; }
    }

}
