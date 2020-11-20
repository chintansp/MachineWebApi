using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace MachineWebApi.Controllers
{
    public class MachineDataController : ApiController
    {
        public IEnumerable<Machine_Data> Get(int id)
        {
            using (FleetMachinesEntities1 entities = new FleetMachinesEntities1())
            {              
                return entities.Machine_Data.ToList().Where(e => e.MachineID == id && e.CustomerID == "CUST01"); ;
            }
        }


        public HttpResponseMessage SendEmail(string data)
        {
            MailMessage objetoMail = new MailMessage { IsBodyHtml = true };
            SmtpClient client = new SmtpClient();
            objetoMail.To.Add(new MailAddress("arun@myvolvo-1.pagerduty.com"));
           // objetoMail.CC.Add(new MailAddress("arun.gopinath@volvo.com"));
            objetoMail.From = new MailAddress("arun.gopinath@volvo.com");
            objetoMail.Subject = "Total Break down of Machine with chassis ID A-23456677 ";
           // objetoMail.Body = "Total Break down of Machine with chassis ID A-23456677";
            client.Send(objetoMail);
            return Request.CreateResponse(HttpStatusCode.OK); 
        }  
        
    }




}
