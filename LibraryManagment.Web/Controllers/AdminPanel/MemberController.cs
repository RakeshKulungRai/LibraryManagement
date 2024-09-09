using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
