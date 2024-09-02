using LibraryManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain
{
    public class Publisher:BaseDomainEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
