using LibraryMangment.Application.DTOs.Book;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {

            List<BookDto> books = new List<BookDto>
            {
                new BookDto
                {
                    Id = 1,
                    ISBN = "978-1-56619-909-4",
                    Title = "1984",
                    Category = "Dystopian",
                    Price = "9.99",
                    Edition = "Signet Classics",
                    PublishedYear = "1949",
                    PublisherId = 1
                },
        new BookDto
        {
            Id = 2,
            ISBN = "978-0-446-31078-9",
            Title = "To Kill a Mockingbird",
            Category = "Fiction",
            Price = "7.99",
            Edition = "Grand Central Publishing",
            PublishedYear = "1960",
            PublisherId = 2
        },
        new BookDto
        {Id = 3,
            ISBN = "978-0-7432-7356-5",
            Title = "The Great Gatsby",
            Category = "Classic",
            Price = "6.99",
            Edition = "Scribner",
            PublishedYear = "1925",
            PublisherId = 3
        }
            };
            return View(books);
        }

        public IActionResult CreateEdit(int id)
        {
            BookDto book = new BookDto();
            if(id > 0)
            {
                book = new BookDto
                {
                    ISBN = "978-0-446-31078-9",
                    Title = "To Kill a Mockingbird",
                    Category = "Fiction",
                    Price = "7.99",
                    Edition = "Grand Central Publishing",
                    PublishedYear = "1960",
                    PublisherId = 2
                };
            }
            return View(book);
        }
        public IActionResult Save(BookDto book)
        {
            Console.WriteLine(book.Title);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
