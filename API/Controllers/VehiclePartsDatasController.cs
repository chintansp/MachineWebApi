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
    public class VehiclePartsDatasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public VehiclePartsDatasController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/VehiclePartsDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehiclePartsData>>> GetVehiclePartsData()
        {
            return await _context.VehiclePartsData.ToListAsync();
        }

        // GET: api/VehiclePartsDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehiclePartsData>> GetVehiclePartsData(int id)
        {
            var vehiclePartsData = await _context.VehiclePartsData.FindAsync(id);

            if (vehiclePartsData == null)
            {
                return NotFound();
            }

            return vehiclePartsData;
        }

        // PUT: api/VehiclePartsDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiclePartsData(int id, VehiclePartsData vehiclePartsData)
        {
            if (id != vehiclePartsData.VehicleId)
            {
                return BadRequest();
            }

            _context.Entry(vehiclePartsData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiclePartsDataExists(id))
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

        // POST: api/VehiclePartsDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VehiclePartsData>> PostVehiclePartsData(VehiclePartsData vehiclePartsData)
        {
            _context.VehiclePartsData.Add(vehiclePartsData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiclePartsData", new { id = vehiclePartsData.VehicleId }, vehiclePartsData);
        }

        // DELETE: api/VehiclePartsDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VehiclePartsData>> DeleteVehiclePartsData(int id)
        {
            var vehiclePartsData = await _context.VehiclePartsData.FindAsync(id);
            if (vehiclePartsData == null)
            {
                return NotFound();
            }

            _context.VehiclePartsData.Remove(vehiclePartsData);
            await _context.SaveChangesAsync();

            return vehiclePartsData;
        }

        private bool VehiclePartsDataExists(int id)
        {
            return _context.VehiclePartsData.Any(e => e.VehicleId == id);
        }
    }
}
