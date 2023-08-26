namespace LibraryManagementSystem.Models
{
    public class Book
    {
        /*
         مثلا اگر از کتاب مهندسی نرم افزار راجر اس پرسمن 10 تا داریم،
         هر کدام یک آی دی منحصر به فرد دارد
            ولی ISBN آنها یکی است   
         */
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        public int YearOfPublication { get; set; }
        public decimal Price { get; set; }        
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
        public List<Author> Authors { get; set; }
        public int Status { get; set; }

        public void UpdateStatus()
        {

        }

        public void GetQuantity()
        {

        }

        public void GetAvailableQuantity()
        {

        }
    }    
}
