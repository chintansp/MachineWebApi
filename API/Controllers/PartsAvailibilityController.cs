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
    public class PartsAvailibilityController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public PartsAvailibilityController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/PartsAvailibility
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PartsAvailibility>>> GetPartsAvailibilities()
        {
            return await _context.PartsAvailibilities.ToListAsync();
        }

        // GET: api/PartsAvailibility/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PartsAvailibility>> GetPartsAvailibility(int id)
        {
            var partsAvailibility = await _context.PartsAvailibilities.FindAsync(id);

            if (partsAvailibility == null)
            {
                return NotFound();
            }

            return partsAvailibility;
        }

        // PUT: api/PartsAvailibility/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartsAvailibility(int id, PartsAvailibility partsAvailibility)
        {
            if (id != partsAvailibility.PartId)
            {
                return BadRequest();
            }

            _context.Entry(partsAvailibility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartsAvailibilityExists(id))
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

        // POST: api/PartsAvailibility
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PartsAvailibility>> PostPartsAvailibility(PartsAvailibility partsAvailibility)
        {
            _context.PartsAvailibilities.Add(partsAvailibility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartsAvailibility", new { id = partsAvailibility.PartId }, partsAvailibility);
        }

        // DELETE: api/PartsAvailibility/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PartsAvailibility>> DeletePartsAvailibility(int id)
        {
            var partsAvailibility = await _context.PartsAvailibilities.FindAsync(id);
            if (partsAvailibility == null)
            {
                return NotFound();
            }

            _context.PartsAvailibilities.Remove(partsAvailibility);
            await _context.SaveChangesAsync();

            return partsAvailibility;
        }

        private bool PartsAvailibilityExists(int id)
        {
            return _context.PartsAvailibilities.Any(e => e.PartId == id);
        }
    }
}
