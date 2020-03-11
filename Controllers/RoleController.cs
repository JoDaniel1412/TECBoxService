using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TECBoxService.DB;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class RoleController : ApiController
    {
        // GET api/<controller>
        public List<Role> Get()
        {
            return DataBaseManager.GetRole();
        }

        // GET api/<controller>/5
        public Role Get(int id)
        {
            return DataBaseManager.GetRole().FirstOrDefault(x => x.EmployeeID == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Role value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Role value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}