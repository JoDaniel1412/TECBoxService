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
    public class EmployeeController : ApiController
    {
        // GET api/<controller>
        public List<Employee> Get()
        {
            return DataBaseManager.GetEmployees();
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return DataBaseManager.GetEmployees().FirstOrDefault(x => x.ID == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Employee value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Employee value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}