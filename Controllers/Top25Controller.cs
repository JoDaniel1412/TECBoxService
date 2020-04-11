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
    public class Top25Controller : ApiController
    {
        // GET api/<controller>
        public List<Product> Get()
        {
            return DataBaseManager.GetTop25Products();
        }       
    }
}