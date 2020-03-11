using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class SubsidiaryController : ApiController
    {
        // GET api/<controller>
        public List<Subsidiary> Get()
        {
            return DataBaseManager.GetSubsidiary();
        }

        // GET api/<controller>/5
        public Subsidiary Get(int id)
        {
            return DataBaseManager.GetSubsidiary().FirstOrDefault(x => x.Id == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Subsidiary value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Subsidiary value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}