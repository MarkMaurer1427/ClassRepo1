namespace WebApp1.Models
{
    public class SqlBookRepo : IBookRepository
    {
        private readonly AppDBContext context;

        public SqlBookRepo(AppDBContext context)
        {
            this.context = context;
        }

        public Book AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }

        public Book DeleteBook(int id)
        {
            Book book = context.Books.Find(id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
        }

        public Book GetBook(int id)
        {
            return context.Books.Find(id);
        }

        public Book UpdateBook(Book book)
        {
            var bookChange = context.Books.Attach(book);
            bookChange.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return book;

        }
    }
}
