namespace OnlineShop.Models
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Weight { get; set; }
        public Category Category { get; set; }
        public Company Company { get; set; }
        public string Description { get; set; }        
    }
}
