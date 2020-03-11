namespace TECBoxService.Models
{
    public class Product
    {
        public long Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long SellerId { get; set; }
        public long Sells { get; set; }
        public int Cost { get; set; }
        public float IVA { get; set; }
        public float Discount { get; set; }
        public int Price { get; set; }
    }
}