using System.Collections.Generic;

namespace WebApp1.Models
{
    public class BookRepo : IBookRepository
    {
        public BookRepo()
        {

            _bookList = new List<Book>()
            {
                new Book(){Id = 0, Title = "Practical Database Programming with Java", Author = "Ying Bai", Language = Language.Java},
                new Book(){Id = 1,Title = "Pro JPA 2", Author ="Mike Keith", Language = Language.Java},
                new Book(){Id = 2, Title = "Python Programming: An Easiest Beginner to Expert Guide to Learn Python", Author = "Andrew Burn", Language = Language.Python}


            };
        
        }
        private List<Book> _bookList;
        public Book GetBook(int id)
        {
            return _bookList.Find(b => b.Id == id);
        }

        IEnumerable<Book> IBookRepository.GetAllBooks()
        {
            return _bookList;
        }

        public Book AddBook(Book book)
        {
            book.Id = _bookList.Max(b => b.Id)+1;
            _bookList.Add(book);
            return book;
        }
    }
}
