using System;
using System.Collections.Generic;
using TECBoxService.Models;

namespace TECBoxService.DB
{
    public class DataBaseManager
    {
        public static List<Employee> GetEmployees() => Deserialize<List<Employee>>("Employee.json");
        
        private static T Deserialize<T>(string file) => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(file);
    }
}