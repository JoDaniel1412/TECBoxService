using System.Collections.Generic;
using System.Web.UI;

namespace TECBoxService.Models
{
    public class Subsidiary
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long PlaceId { get; set; }
        public int Phone { get; set; }
        public int ManagerID { get; set; }
        public int StorageDelegateID { get; set; }
        public List<Pair> Storage { get; set; }
    }
}
