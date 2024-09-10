using LibraryManagment.Domain;
using LibraryMangment.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly LibraryManagmentDbContext _context;
        public TransactionRepository(LibraryManagmentDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
