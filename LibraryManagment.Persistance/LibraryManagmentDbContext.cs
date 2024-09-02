using LibraryManagment.Domain;
using LibraryManagment.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance
{
    public class LibraryManagmentDbContext:DbContext
    {
        private int UserId { get; set; }
        public LibraryManagmentDbContext(DbContextOptions<LibraryManagmentDbContext> options):base(options)
        {
            
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            foreach(var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.UpdatedDate = DateTime.Now;
                entry.Entity.UpdatedBy = UserId;
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = UserId;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
