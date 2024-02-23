using AppHotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly HotelPortalDbContext _context;

        public ReservaController(HotelPortalDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            var listReservas = await _context.Reservas.ToListAsync();
            return Ok(listReservas);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        [HttpPost]
 
        public async Task<IActionResult> Create(Reserva reserva)
        {
            var modelreserva = new Reserva();
            modelreserva.FechaInicio = reserva.FechaInicio;
            modelreserva.FechaFin = reserva.FechaFin;
            modelreserva.Precio = reserva.Precio;
            modelreserva.IdCliente= reserva.IdCliente;
            modelreserva.IdTipoHabitacion = reserva.IdTipoHabitacion;
            try
            {
                _ = _context.Reservas.AddAsync(modelreserva);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Hotel hotel)
        {

            var ids = _context.Hotels.FirstOrDefault(x => x.Id == id);
            if (ids == null)
            {
                return NotFound();
            }

            ids.Descripcion = hotel.Descripcion;
            ids.Nombre = hotel.Nombre;


            _context.Hotels.Update(ids);

            return Ok();
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {

            var ids = _context.Hotels.FirstOrDefault(x => x.Id == id);
            if (ids == null)
            {
                return NotFound();
            }
            _context.Hotels.Remove(ids);

            return Ok();
        }

    }
}
