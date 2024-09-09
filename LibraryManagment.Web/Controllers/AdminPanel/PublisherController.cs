using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
