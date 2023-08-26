namespace LibraryManagementSystem.Models
{
    public class LibraryManagement
    {         
        public void AddBook(Book book)
        {

        }

        public void RemoveBook(int bookId)
        {

        }

        public List<Book> SearchBook(BookSearch bookSearch)
        {
            return null;
        }

        public List<Book> ViewBooks()
        {
            return null;
        }

        public void BorrowBook(Transaction transaction)
        {

        }

        public void ReturnBook(Transaction transaction)
        {

        }

        public void AddMember(Member member)
        {

        }

        public decimal CalculateFine(Transaction transaction)
        {
            int currentdate = 0;//DateTime.Now.Day
            int borrowdate = 0;//transaction.BorrowDate.Day

            int dedifference = currentdate - borrowdate;
            if (dedifference > Fine.MaxDays)
            {
                return Fine.Amount * (dedifference - Fine.MaxDays);
            }
            return 0;
        }
    }
}
