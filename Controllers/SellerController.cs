using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class SellerController : ApiController
    {
        // GET api/<controller>
        public List<Seller> Get()
        {
            return DataBaseManager.GetSellers();
        }

        // GET api/<controller>/5
        public Seller Get(int id)
        {
            return DataBaseManager.GetSellers().FirstOrDefault(x => x.ID == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Seller value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Seller value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}