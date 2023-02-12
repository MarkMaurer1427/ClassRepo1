using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.ViewModels;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository iBookRepo;

        public HomeController(IBookRepository iBookRepo)
        {
            this.iBookRepo = iBookRepo;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> books = iBookRepo.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            Book b = iBookRepo.GetBook(id);
            if (b == null) { return View("BookNotFound",id); }
            else
            {
                HomeDetailsViewModel detailsViewModel = new HomeDetailsViewModel(b, "Details Page");
                return View(detailsViewModel);
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Book del = iBookRepo.GetBook(id);
            return View(del);
        }

        [HttpPost]
        public IActionResult Delete(Book del)
        {
            
            if (del == null) { return View(); }
            else
            {
                del = iBookRepo.DeleteBook(del.BookId);
                return View();
            }
        
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Book bookChange = iBookRepo.GetBook(id);
            return View(bookChange);
        }

        [HttpPost]
        public IActionResult Edit(Book bookChange) 
        {
            if(ModelState.IsValid) 
            {
                
                if (bookChange == null) { return View("BookNotFound", bookChange.BookId); }
                else { 
                    bookChange = iBookRepo.UpdateBook(bookChange);
                    }
                return View();

            }
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                Book newBook = iBookRepo.AddBook(book);
                return RedirectToAction("details", new { id = newBook.BookId });
            }
            return View();
        }
    }
}
