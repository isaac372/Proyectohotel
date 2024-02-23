using AppHotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly HotelPortalDbContext _context;

        public ClienteController(HotelPortalDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetCients()
        {
            var listClients = await _context.Clientes.ToListAsync();
            return Ok(listClients);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Cliente cliente)
        {
            var modelCliente = new Cliente();
            modelCliente.Nombre = cliente.Nombre;
            modelCliente.Apellido = cliente.Apellido;
            modelCliente.Telefono = cliente.Telefono;
         
            try
            {
                await _context.Clientes.AddAsync(modelCliente);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
