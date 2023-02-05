namespace WebApp1.Models
{
    public interface IBookRepository
    {

        public Book GetBook(int id);
        IEnumerable<Book> GetAllBooks();

        public Book AddBook(Book book);



    }
}
