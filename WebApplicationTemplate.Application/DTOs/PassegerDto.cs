namespace WebApplicationTemplate.Application.DTOs
{
    public class PassengerDto
    {
        /// <summary>
        /// Nombre completo del pasajero
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Tipo de pasajero: ADT (Adulto), CHD (Niño)
        /// </summary>
        public string Type { get; set; } = "ADT";

        /// <summary>
        /// Edad pasajero
        /// </summary>
        public int Age { get; set; }
    }
}
