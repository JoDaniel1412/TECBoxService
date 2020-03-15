using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TECBoxService.Controllers
{
    public class ReportsController : ApiController
    {
        // GET api/<controller>
        public void Get()
        {
            DB.ReportsXML.GenerateTop25Products();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
    }
}