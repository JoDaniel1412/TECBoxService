using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class RouteController : ApiController
    {
        // GET api/<controller>
        public List<Route> Get()
        {
            return DataBaseManager.GetRoute();
        }

        // GET api/<controller>/5
        public Route Get(int id)
        {
            return DataBaseManager.GetRoute().FirstOrDefault(x => x.Id == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Route value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Route value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}