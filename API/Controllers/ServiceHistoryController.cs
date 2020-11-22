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
    public class ServiceHistoryController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public ServiceHistoryController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/ServiceHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceHistory>>> GetServiceHistories()
        {
            return await _context.ServiceHistories.ToListAsync();
        }

        // GET: api/ServiceHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceHistory>> GetServiceHistory(int id)
        {
            var serviceHistory = await _context.ServiceHistories.FindAsync(id);

            if (serviceHistory == null)
            {
                return NotFound();
            }

            return serviceHistory;
        }

        // PUT: api/ServiceHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceHistory(int id, ServiceHistory serviceHistory)
        {
            if (id != serviceHistory.VehicleId)
            {
                return BadRequest();
            }

            _context.Entry(serviceHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceHistoryExists(id))
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

        // POST: api/ServiceHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ServiceHistory>> PostServiceHistory(ServiceHistory serviceHistory)
        {
            _context.ServiceHistories.Add(serviceHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceHistory", new { id = serviceHistory.VehicleId }, serviceHistory);
        }

        // DELETE: api/ServiceHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceHistory>> DeleteServiceHistory(int id)
        {
            var serviceHistory = await _context.ServiceHistories.FindAsync(id);
            if (serviceHistory == null)
            {
                return NotFound();
            }

            _context.ServiceHistories.Remove(serviceHistory);
            await _context.SaveChangesAsync();

            return serviceHistory;
        }

        private bool ServiceHistoryExists(int id)
        {
            return _context.ServiceHistories.Any(e => e.VehicleId == id);
        }
    }
}
