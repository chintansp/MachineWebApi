using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleUpTimeDataController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public VehicleUpTimeDataController(CoreDbContext context)
        {
            _context = context;
        }
        // GET: api/<VehicleUpTimeDataController>

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        // GET: api/<VehicleUpTimeDataController>
        [HttpGet]
            public async Task<ActionResult<IEnumerable<VehicleUpTimeData>>> Get()
            {
                return await _context.VehicleUpTimeData.ToListAsync();
            }

        

        // GET api/<VehicleUpTimeDataController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleUpTimeData>> Get(int id)
        {
            VehicleUpTimeData obj = await _context.VehicleUpTimeData.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            return obj;
        }

        // POST api/<VehicleUpTimeDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleUpTimeDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleUpTimeDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
