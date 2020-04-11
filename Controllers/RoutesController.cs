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
    public class RoutesController : ApiController
    {
        // GET api/<controller>
        public List<Package> Get()
        {
            var routeId = Convert.ToInt64(Request.Headers.GetValues("routeId").First());
            return DataBaseManager.GetRoutesReport(routeId);
        }
    }
}