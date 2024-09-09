using LibraryMangment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.DTOs.Transaction
{
    public class TransactionDto:BaseDto
    {
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
    }
}
