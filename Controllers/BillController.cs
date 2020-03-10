using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class BillController : ApiController
    {
        // GET api/<controller>
        public List<Bill> Get()
        {
            return DataBaseManager.GetBill();
        }

        // GET api/<controller>/5
        public Bill Get(int id)
        {
            return DataBaseManager.GetBill().FirstOrDefault(x => x.Id == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Bill value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Bill value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}