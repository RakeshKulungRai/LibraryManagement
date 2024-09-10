using LibraryManagment.Domain;
using LibraryManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.Contracts.Persistance
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
    }
}
