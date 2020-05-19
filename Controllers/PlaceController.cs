using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class PlaceController : ApiController
    {
        // GET api/<controller>
        public List<Place> Get()
        {
            return DataBaseManager.GetPlace();
        }

        // GET api/<controller>/5
        public Place Get(int id)
        {
            return DataBaseManager.GetPlace().FirstOrDefault(x => x.PlaceId == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Place value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Place value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}