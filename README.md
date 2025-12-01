# FlightBookingAPI

## Descripción

Esta API permite consultar vuelos disponibles, crear reservas, cancelar reservas y obtener información de reservas existentes.  
El proyecto está diseñado siguiendo una arquitectura por capas, aplicando buenas prácticas de SOLID, validaciones de negocio, manejo de errores, logging y pruebas unitarias.

---

## Funcionalidades

- Consultar vuelos disponibles.
- Crear una reserva de vuelo.
- Cancelar una reserva.
- Consultar reserva por ID.

---

## Arquitectura

El proyecto sigue la arquitectura por capas:

### **API**
- Controladores REST (`FlightsController`, `BookingsController`)
- Validación inicial de datos
- Solo recibe Request y devuelve Response
- Response con códigos HTTP correctos (`200`, `400`, `404`, `500`)

### **Application**
- Casos de uso: `GetAvailableFlights`, `CreateBooking`, `CancelBooking`, `GetBookingById`
- Valida reglas de negocio usando Domain
- Recupera y guarda datos usando Infrastructure
- Uso de DTOs y mappers

### **Domain**
- Entidades: `Flight`, `Booking`
- Reglas y lógica de negocio
- Validaciones de datos y operaciones

### **Infrastructure**
- Repositorios de datos (`IFlightRepository`, `IBookingRepository`)
- Integración con fuentes externas simuladas (JSON)
- Manejo de caché en memoria (`MemoryCache`)
- Implementación de interfaces definidas en Domain/Application

---

## Validaciones y Reglas de Negocio

- No se puede reservar un vuelo si no hay asientos disponibles.
- El email del pasajero debe tener formato válido.
- No se puede cancelar una reserva ya cancelada.
- Todos los parámetros obligatorios deben ser validados.
- Los errores devuelven mensajes claros y códigos HTTP estándar.

---

## Calidad del Código

- Principios SOLID aplicados
- Métodos pequeños y con única responsabilidad
- No duplicar lógica
- Uso de interfaces para servicios e infraestructura
- Separación entre modelos de dominio y DTOs
- Uso de Async/Await en métodos asíncronos
- Documentación XML en métodos públicos
- Logging de errores y operaciones importantes usando ILogger

---

## Persistencia

- Uso de `MemoryCache` para almacenamiento temporal
- Claves únicas en campos `Id` (BookingId, FlightId)
- Datos iniciales generados a partir de archivos JSON

---

## Pruebas Unitarias

- Proyecto de tests independiente
- Uso de `xUnit` o `NSubstitute`
- Mocks para simular dependencias
- Tests unitarios independientes que comprueban un solo comportamiento
  - Creación de reserva válida
  - Creación de reserva sin asientos disponibles
  - Cancelación de reserva exitosa
  - Cancelación de reserva inexistente

---

## Integraciones

- Fuente de datos simulada a partir de archivos JSON
- Servicios externos simulados
- Cache en memoria para mejorar rendimiento

---

## Cómo Ejecutar el Proyecto

1. Clonar el repositorio:
```bash
git clone <URL>
