using System.Collections.Generic;

namespace TECBoxService.Models
{
    public class Subsidiary
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public Employee Manager { get; set; }
        public Employee StorageDelegate { get; set; }
        public List<Product> Storage { get; set; }
    }
}
