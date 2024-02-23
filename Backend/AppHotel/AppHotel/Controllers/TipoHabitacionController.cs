using AppHotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoHabitacionController : ControllerBase
    {

        private readonly HotelPortalDbContext _context;

        public TipoHabitacionController(HotelPortalDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAbitacions()
        {
            var listHabitacions = await _context.TipoHabitacions.ToListAsync();
            return Ok(listHabitacions);
        }

    }
}
