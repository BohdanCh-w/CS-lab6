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
    public class EquipmentController : ControllerBase {
        private readonly ClubDbContext _context;
        public EquipmentController(ClubDbContext context) {
            _context = context;
        }

        //GET: api/Equipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipments() {
            return await _context.Equipments.ToListAsync();
        }

        //GET: api/Equipment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment>> GetEquipment(long id) {
            var equipment = await _context.Equipments.FindAsync(id);
            if(equipment == null) {
                return NotFound();
            }

            return equipment;
        }
    }
}
