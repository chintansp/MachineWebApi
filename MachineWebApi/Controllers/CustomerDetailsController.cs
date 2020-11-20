using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MachineWebApi.Controllers
{
    public class CustomerDetailsController : ApiController
    {
        public CustomerDetail Get(string id)
        {
            using (FleetMachinesEntities1 entity=new FleetMachinesEntities1())
            {
               return entity.CustomerDetails.FirstOrDefault(e => e.CustomerId == id);
            }
        }
    }
}
