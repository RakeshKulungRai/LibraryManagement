using LibraryManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain
{
    public class Transaction:BaseDomainEntity
    {
        public  DateTime IssueDate {  get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public  Book Book { get; set; }
        public Member Reader { get; set; }
    }
}
