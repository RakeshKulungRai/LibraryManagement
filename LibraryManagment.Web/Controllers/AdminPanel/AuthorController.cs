using LibraryMangment.Application.DTOs.Author;
using LibraryMangment.Application.DTOs.Book;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            IList<AuthorDto> author = [];

            return View(author);
        }
        public IActionResult CreateEdit(int id)
        {
            AuthorDto authorDto = new AuthorDto();
            return View(authorDto);
        }
        public IActionResult Save(AuthorDto author)
        {
            return RedirectToAction("Index");
        }
    }
}
