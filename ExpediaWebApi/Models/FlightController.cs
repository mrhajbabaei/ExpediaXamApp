using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpediaWebApi.Models;

namespace ExpediaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly FlightContext _context;

        public FlightController(FlightContext context)
        {
            _context = context;

            if (_context.FlightItems.Count() == 0)
            {

                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 1, FlightNumber =152, Departure="IKA", Arrival="DXP", STD="09:00", STA="12:00",
                    ATD ="", ATA="", DepartureGateNumber=20, ArrivalGateNumber=52
                });
                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 2, FlightNumber = 151, Departure = "DXP", Arrival = "IKA", STD = "16:00", STA = "19:00",
                    ATD = "", ATA = "", DepartureGateNumber = 27, ArrivalGateNumber = 85
                });
                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 3, FlightNumber = 14, Departure = "THR", Arrival = "MHD", STD = "08:00", STA = "10:00",
                    ATD = "08:10", ATA = "10:10", DepartureGateNumber = 27, ArrivalGateNumber = 85
                });
                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 4, FlightNumber = 13, Departure = "MHD", Arrival = "KER", STD = "11:00", STA = "13:00",
                    ATD = "11:00", ATA = "", DepartureGateNumber = 27, ArrivalGateNumber = 85
                });
                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 5, FlightNumber = 12, Departure = "KER", Arrival = "MHD", STD = "14:00", STA = "15:00",
                    ATD = "", ATA = "", DepartureGateNumber = 27, ArrivalGateNumber = 85
                });
                _context.FlightItems.Add(new FlightItem()
                {
                    Id = 6, FlightNumber = 11, Departure = "MHD", Arrival = "THR", STD = "16:00", STA = "17:00",
                    ATD = "", ATA = "", DepartureGateNumber = 27, ArrivalGateNumber = 85
                });

                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightItem>>> GetFlightItems()
        {
            return await _context.FlightItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FlightItem>> GetFlightItem(long id)
        {
            var todoItem = await _context.FlightItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [HttpPost]
        public async Task<ActionResult<FlightItem>> PostFlightItem(FlightItem item)
        {
            _context.FlightItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFlightItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightItem(long id, FlightItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightItem(long id)
        {
            var todoItem = await _context.FlightItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.FlightItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}