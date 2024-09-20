using LibraryMangment.Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LibraryManagmentDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(LibraryManagmentDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(true);
            return entity;
        }
        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(true);
        }
        public async Task<T> Get(int Id)
        {
            return await _dbSet.FindAsync(Id) ;
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(true);
            return entity;
        }


    }
}
