using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsInventoryController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public PartsInventoryController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/PartsInventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PartsInventory>>> GetPartsInventories()
        {
            return await _context.PartsInventories.ToListAsync();
        }

        // GET: api/PartsInventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PartsInventory>> GetPartsInventory(int id)
        {
            var partsInventory = await _context.PartsInventories.FindAsync(id);

            if (partsInventory == null)
            {
                return NotFound();
            }

            return partsInventory;
        }

        // PUT: api/PartsInventories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartsInventory(int id, PartsInventory partsInventory)
        {
            if (id != partsInventory.Id)
            {
                return BadRequest();
            }

            _context.Entry(partsInventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartsInventoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PartsInventories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PartsInventory>> PostPartsInventory(PartsInventory partsInventory)
        {
            _context.PartsInventories.Add(partsInventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartsInventory", new { id = partsInventory.Id }, partsInventory);
        }

        // DELETE: api/PartsInventories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PartsInventory>> DeletePartsInventory(int id)
        {
            var partsInventory = await _context.PartsInventories.FindAsync(id);
            if (partsInventory == null)
            {
                return NotFound();
            }

            _context.PartsInventories.Remove(partsInventory);
            await _context.SaveChangesAsync();

            return partsInventory;
        }

        private bool PartsInventoryExists(int id)
        {
            return _context.PartsInventories.Any(e => e.Id == id);
        }
    }
}
