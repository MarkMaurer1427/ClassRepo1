using WebApp1.Models;

namespace WebApp1.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Book book;
        public string title;

        public HomeDetailsViewModel(Book b, string v)
        {
            this.book = b;
            this.title = v;
        }

    }
}
