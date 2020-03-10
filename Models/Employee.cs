using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECBoxService.Models
{
    public class Employee : Person
    {
        public long SubsidiaryId { get; set; }
        public DateTime Birthdate { get; set; }
        public string Role { get; set; }
        public string SalaryHour { get; set; }
        public int WorkedHours { get; set; }
        public int SalaryMonth { get; set; }
    }
}