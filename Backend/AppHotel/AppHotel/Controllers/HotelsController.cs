using AppHotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {

        private readonly HotelPortalDbContext _context;

        public HotelsController(HotelPortalDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            var listHotels = await _context.Hotels.ToListAsync();
            return Ok(listHotels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _context.Hotels.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Hotel hotel)
        {
            var modelHotels = new Hotel();
            modelHotels.Descripcion = hotel.Descripcion;
            modelHotels.Nombre = hotel.Nombre;

            try
            {
                await _context.Hotels.AddAsync(modelHotels);
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
