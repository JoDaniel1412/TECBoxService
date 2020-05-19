using System;
using System.Collections.Generic;
using System.Web.UI;

namespace TECBoxService.Models
{
    public class Package
    {
        public Package ()
        {
            TrackingId = 0;
            Products = new List<Pair>();
            BillId = 0;
            State = "";
            RouteId = 0;
            Departure = new DateTime();
            Arrive = new DateTime();
            Deliver = new DateTime();
        }

        public long TrackingId { get; set; }
        // List of prices [productId, quantity]
        public List<Pair> Products { get; set; }
        public long BillId { get; set; }
        public string State { get; set; }
        public long RouteId { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrive { get; set; }
        public DateTime Deliver { get; set; }
    }
}