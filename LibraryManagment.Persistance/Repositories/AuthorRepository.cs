using LibraryManagment.Domain.Common;
using LibraryMangment.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly LibraryManagmentDbContext _context;
        public AuthorRepository(LibraryManagmentDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
