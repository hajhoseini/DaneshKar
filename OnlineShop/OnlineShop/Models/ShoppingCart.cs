namespace OnlineShop.Models
{
    public class ShoppingCart
    {
        public DateTime Date { get; set; }
        public Customer Customer {get; set;}        
        public List<ShoppingItem> ShoppingItems { get; set; }        
    }
}
