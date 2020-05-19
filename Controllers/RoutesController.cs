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
            var routeIdStr = Request.Headers.GetValues("routeId").First();
            long routeId;
            if (routeIdStr.Equals("")) routeId = -1;
            else
            {
                try
                {
                    routeId = long.Parse(routeIdStr);
                }
                catch
                {
                    routeId = -2;
                }
            }
            return DataBaseManager.GetRoutesReport(routeId);
        }
    }
}