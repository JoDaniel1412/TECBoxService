using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TECBoxService.Models;

namespace TECBoxService.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employees = new List<Employee>();

        public EmployeeController()
        {
        }

        // GET api/<controller>
        public List<Employee> Get()
        {
            return employees;
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return employees.Where(x => x.ID == id).FirstOrDefault();
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