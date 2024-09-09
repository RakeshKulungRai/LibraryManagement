using LibraryMangment.Application.DTOs.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEdit(int Id)
        {
            TransactionDto transactionDto = new TransactionDto();
            return View(transactionDto);
        }
    }
}
