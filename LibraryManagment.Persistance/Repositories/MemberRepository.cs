using LibraryManagment.Domain;
using LibraryMangment.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance.Repositories
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        private readonly LibraryManagmentDbContext _context;
        public MemberRepository(LibraryManagmentDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
