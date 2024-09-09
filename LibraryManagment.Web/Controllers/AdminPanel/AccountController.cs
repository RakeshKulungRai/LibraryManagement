using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
