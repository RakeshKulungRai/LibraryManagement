using LibraryMangment.Application.DTOs.Publisher;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEdit(int Id)
        {
            PublisherDto publisher = new PublisherDto();
            return View(publisher);
        }
    }
}
