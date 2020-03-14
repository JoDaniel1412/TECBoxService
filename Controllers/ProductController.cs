using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public List<Product> Get()
        {
            return DataBaseManager.GetProduct();
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return DataBaseManager.GetProduct().FirstOrDefault(x => x.Barcode == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Product value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Product value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}