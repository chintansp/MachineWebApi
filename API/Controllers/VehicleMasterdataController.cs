using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.API.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMasterdataController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public VehicleMasterdataController(CoreDbContext context)
        {
            _context = context;
        }
        // GET: api/<VehicleDataController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return _context.VehicleMasterdata.ToList();
        //}
        public async Task<ActionResult<IEnumerable<VehicleMasterdata>>> Get()
        {
            return await _context.VehicleMasterdata.ToListAsync();
        }
        
        // GET api/<VehicleDataController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleMasterdata>> Get(int id)
        {
            VehicleMasterdata obj = await _context.VehicleMasterdata.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            return obj;
        }

        // POST api/<VehicleDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
