using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MachineWebApi.Controllers
{
    public class MachineController : ApiController
    {
        public IEnumerable<Machine_Data> Get()
        {
            using (FleetMachinesEntities1 entities = new FleetMachinesEntities1())
            {
                return entities.Machine_Data.ToList();
            }
        }

        public IEnumerable<Machine_Data> Get(string id)
        {
            using (FleetMachinesEntities1 entities = new FleetMachinesEntities1())
            {
                return entities.Machine_Data.ToList().Where(e => e.CustomerID == id);
            }
        }

        
    }
}
