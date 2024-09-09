using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEdit(int  id)
        {
            return View();
        }
    }
}
