using LibraryManagment.Domain;
using LibraryMangment.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance.Repositories
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        private LibraryManagmentDbContext _context;
        public PublisherRepository(LibraryManagmentDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
