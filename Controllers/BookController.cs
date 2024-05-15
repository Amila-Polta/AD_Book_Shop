using Microsoft.AspNetCore.Mvc;
using AD_Book_Shop.Models.Book;

namespace AD_Book_Shop.Controllers
{
    public class BookController : Controller
    {
		[ViewData]
		public string Pagetitle { get; set; }
		
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Pagetitle = "Book Details";

            var book = new BookService
            {
                Id = Guid.NewGuid(),
                BookName = "Arosh"

            };

            ViewBag.Book = book;

            return View();
        }

    }
}
