namespace OnlineShop.Models
{
    public class Order
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal FinalAmount { get; set; }
        public int Status { get; set; }

        public decimal CalculateTotalPrice(){ return 0; }
        public decimal CalculateTotalDiscount(){ return 0; }
        public decimal CalculateFinalAmount(){ return 0; }
    }
}
