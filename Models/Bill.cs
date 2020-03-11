using System;
using System.Collections.Generic;
using System.Web.UI;

namespace TECBoxService.Models
{
    public class Bill
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long ClientId { get; set; }
        public long PackageId { get; set; }
        public int TotalPrice { get; set; }
        // List of prices [productId, price]
        public List<Pair> IndividualPrices { get; set; }
    }
}