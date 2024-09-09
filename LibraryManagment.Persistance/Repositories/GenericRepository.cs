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
        private readonly LibraryManagmentDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(LibraryManagmentDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync(true);
            return entity;
        }
        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync(true);
        }
        public async Task<T> Get(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(true);
            return entity;
        }


    }
}
