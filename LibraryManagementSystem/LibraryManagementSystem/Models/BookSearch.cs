namespace LibraryManagementSystem.Models
{
    public class BookSearch
    {
        public string BookName { get; set; }
        public string AutherName { get; set; }
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
    }
}
