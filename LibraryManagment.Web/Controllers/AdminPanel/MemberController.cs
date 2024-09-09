using LibraryMangment.Application.DTOs.Member;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEdit(int id)
        {
            MemberDto member = new MemberDto();
            return View(member);
        }
    }
}
