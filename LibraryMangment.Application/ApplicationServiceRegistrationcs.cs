using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application
{
    public static class ApplicationServiceRegistrationcs
    {
        public static IServiceCollection ConfigurationApplicationServiceRegistrationcs(IServiceCollection services,IConfiguration configuration)
        {
            return services; 
        }
    }
}
