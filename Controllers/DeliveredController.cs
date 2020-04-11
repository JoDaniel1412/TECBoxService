using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class DeliveredController : ApiController
    {
        // GET api/<controller>
        public List<Package> Get()
        {
            var startDate = Convert.ToDateTime(Request.Headers.GetValues("startDate").First());
            var finalDate = Convert.ToDateTime(Request.Headers.GetValues("finalDate").First());
            return DataBaseManager.GetDelivered(startDate, finalDate);
        }
    }
}