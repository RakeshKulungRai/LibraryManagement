using LibraryManagment.Persistance.Repositories;
using LibraryMangment.Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistanceServiceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryManagmentDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("dbconnections"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            return services;
        }
    }
}
