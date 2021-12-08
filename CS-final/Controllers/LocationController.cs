using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_final.Models;
using Microsoft.EntityFrameworkCore;

namespace CS_final.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase {
        private readonly ClubDbContext _context;
        public LocationController(ClubDbContext context) {
            _context = context;
        }

        //GET: api/Location
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations() {
            return await _context.Locations.ToListAsync();
        }

        //GET: api/Location/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(long id) {
            var location = await _context.Locations.FindAsync(id);
            if(location == null) {
                return NotFound();
            }

            return location;
        }

        // PUT: api/Location/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(long id, Location location) {
            if (id != location.LocationId) {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!LocationExists(id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Location
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostCustomer(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.LocationId}, location);
        }

        // DELETE: api/Location/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(long id) {
            var location = await _context.Locations.FindAsync(id);
            if (location == null) {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(long id) {
            return _context.Locations.Any(e => e.LocationId == id);
        }
    }
}
