using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
