using LibraryMangment.Application.DTOs.Author;
using LibraryMangment.Application.DTOs.Publisher;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            IList<PublisherDto> publishers = [];
            return View(publishers);
        }
        public IActionResult CreateEdit(int Id)
        {
            PublisherDto publisher = new PublisherDto();
            return View(publisher);
        }
        public IActionResult Save(PublisherDto publisher)
        {
            return RedirectToAction("Index");
        }
    }
}
