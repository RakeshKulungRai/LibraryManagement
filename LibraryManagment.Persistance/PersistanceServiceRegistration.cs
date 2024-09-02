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
        public static IServiceCollection ConfigurePersistanceServiceRegistration(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<LibraryManagmentDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("dbconnections"));
            });
            return services;
        }
    }
}
