using System;
using System.Collections.Generic;
using System.Web.UI;

namespace TECBoxService.Models
{
    public class Bill
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public Package Package { get; set; }
        public int TotalPrice { get; set; }
        // List of prices [product, price]
        public List<Pair> IndividualPrices { get; set; }
    }
}