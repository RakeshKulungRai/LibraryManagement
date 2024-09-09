using LibraryMangment.Application.DTOs.Author;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CreateEdit(int id)
        {
            AuthorDto authorDto = new AuthorDto();
            return View(authorDto);
        }
    }
}
