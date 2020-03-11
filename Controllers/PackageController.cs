using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class PackageController : ApiController
    {
        // GET api/<controller>
        public List<Package> Get()
        {
            return DataBaseManager.GetPackage();
        }

        // GET api/<controller>/5
        public Package Get(int id)
        {
            return DataBaseManager.GetPackage().FirstOrDefault(x => x.TrackingId == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Package value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Package value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}