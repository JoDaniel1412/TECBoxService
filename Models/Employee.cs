using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECBoxService.Models
{
    public class Employee : Person
    {
        public long SubsidiaryId { get; set; }
        public DateTime Birthday { get; set; }
        public Role Role { get; set; }
        public int SalaryHour { get; set; }
        public int WorkedHours { get; set; }
        public int SalaryMonth { get; set; }
    }
}