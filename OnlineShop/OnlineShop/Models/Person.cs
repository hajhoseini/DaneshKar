namespace OnlineShop.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Login(){}            
        public void Logout(){}
        public void ChangePassword(){}
    }
}
