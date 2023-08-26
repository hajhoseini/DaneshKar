namespace LibraryManagementSystem.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public Librarian CreateUser { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool HasFine { get; set; }
    }
}
