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
    public class GameController : ControllerBase {
        private readonly ClubDbContext _context;
        public GameController(ClubDbContext context) {
            _context = context;
        }

        //GET: api/Game
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames() {
            return await _context.Games.ToListAsync();
        }

        //GET: api/Game/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(long id) {
            var game = await _context.Games.FindAsync(id);
            if(game == null) {
                return NotFound();
            }

            return game;
        }

        // // PUT: api/Game/5
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutGame(long id, Game game) {
        //     if (id != game.GameId) {
        //         return BadRequest();
        //     }

        //     _context.Entry(game).State = EntityState.Modified;

        //     foreach (EquipmentUsage item in game.EquipmentUsages) {
        //         if (item.EquipmentUsageId == 0)
        //             _context.EquipmentUsages.Add(item);
        //         else
        //             _context.Entry(item).State = EntityState.Modified;
        //     }

        //     foreach (var i in game.DeletedOrderItemIds.Split(',').Where(x => x !="")) {
        //         OrderDetail y = _context.OrderDetails.Find(Convert.ToInt64(i));
        //         _context.OrderDetails.Remove(y);
        //     }

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!OrderMasterExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // POST: api/Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.GameId }, game);
        }

        // DELETE: api/Game/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(long id) {
            var game = await _context.Games.FindAsync(id);
            if (game == null) {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameExists(long id) {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}
