using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MachineWebApi;
using EntityState = System.Data.Entity.EntityState;

namespace MachineWebApi.Controllers
{
    public class VehicleMasterdatasController : ApiController
    {
        private FleetCare db = new FleetCare();

        // GET: api/VehicleMasterdatas
        public IQueryable<VehicleMasterdata> GetVehicleMasterdatas()
        {
            return db.VehicleMasterdatas;
        }

        // GET: api/VehicleMasterdatas/5
        [ResponseType(typeof(VehicleMasterdata))]
        public IHttpActionResult GetVehicleMasterdata(int id)
        {
            VehicleMasterdata vehicleMasterdata = db.VehicleMasterdatas.Find(id);
            if (vehicleMasterdata == null)
            {
                return NotFound();
            }

            return Ok(vehicleMasterdata);
        }

        // PUT: api/VehicleMasterdatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVehicleMasterdata(int id, VehicleMasterdata vehicleMasterdata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicleMasterdata.ID)
            {
                return BadRequest();
            }

            db.Entry(vehicleMasterdata).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleMasterdataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VehicleMasterdatas
        [ResponseType(typeof(VehicleMasterdata))]
        public IHttpActionResult PostVehicleMasterdata(VehicleMasterdata vehicleMasterdata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VehicleMasterdatas.Add(vehicleMasterdata);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vehicleMasterdata.ID }, vehicleMasterdata);
        }

        // DELETE: api/VehicleMasterdatas/5
        [ResponseType(typeof(VehicleMasterdata))]
        public IHttpActionResult DeleteVehicleMasterdata(int id)
        {
            VehicleMasterdata vehicleMasterdata = db.VehicleMasterdatas.Find(id);
            if (vehicleMasterdata == null)
            {
                return NotFound();
            }

            db.VehicleMasterdatas.Remove(vehicleMasterdata);
            db.SaveChanges();

            return Ok(vehicleMasterdata);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleMasterdataExists(int id)
        {
            return db.VehicleMasterdatas.Count(e => e.ID == id) > 0;
        }
    }
}