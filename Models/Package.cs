using System;
using System.Collections.Generic;
using System.Web.UI;

namespace TECBoxService.Models
{
    public class Package
    {
        
        public long TrackingId { get; set; }
        // List of prices [product, quantity]
        public List<Pair> Products { get; set; }
        public long BillId { get; set; }
        public string State { get; set; }
        public Route Route { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrive { get; set; }
        public DateTime DeliverTime { get; set; }
    }
}