using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain.Common
{
    public class Author:BaseDomainEntity
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string? BioGraphy { get; set; }
        public byte[]? Image { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
