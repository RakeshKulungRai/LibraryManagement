using LibraryMangment.Application.DTOs.Author;
using LibraryMangment.Application.DTOs.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            List<TransactionDto> transactions = [];
            return View(transactions);
        }
        public IActionResult CreateEdit(int Id)
        {
            TransactionDto transactionDto = new TransactionDto();
            return View(transactionDto);
        }
        public IActionResult Save(TransactionDto transaction)
        {
            return RedirectToAction("Index");
        }
    }
}
