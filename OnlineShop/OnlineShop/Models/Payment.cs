namespace OnlineShop.Models
{
    public class Payment
    {
        public int PaymentType { get; set; }

        public void GoToOnlinePayment(string ShopAccountNumner, decimal Amount, Account CustomerAccount){}
        public void DisplayeTrackingCode(){}
    }
}
