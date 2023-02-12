namespace WebApp1.Models
{
    public interface IBookRepository
    {

        public Book GetBook(int id);
        IEnumerable<Book> GetAllBooks();

        public Book AddBook(Book book);

        public Book UpdateBook(Book book);

        public Book DeleteBook(int id);



    }
}
