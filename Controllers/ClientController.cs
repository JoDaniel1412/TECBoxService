using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class ClientController : ApiController
    {
        // GET api/<controller>
        public List<Client> Get()
        {
            return DataBaseManager.GetClient();
        }

        // GET api/<controller>/5
        public Client Get(int id)
        {
            return DataBaseManager.GetClient().FirstOrDefault(x => x.ID == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Client value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Client value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}