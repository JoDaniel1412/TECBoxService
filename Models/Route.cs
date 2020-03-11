using System;
using System.Collections.Generic;

namespace TECBoxService.Models
{
    public class Route
    {
        public long Id { get; set; }
        public List<long> Directions { get; set; }
        public List<long> Products { get; set; }
        public DateTime Date { get; set; }
        public Employee DeliveryMan { get; set; }
    }
}