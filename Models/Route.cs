using System;
using System.Collections.Generic;

namespace TECBoxService.Models
{
    public class Route
    {
        public long Id { get; set; }
        public List<Place> Directions { get; set; }
        public List<Package> Products { get; set; }
        public DateTime Date { get; set; }
        public Employee DeliveryMan { get; set; }
    }
}