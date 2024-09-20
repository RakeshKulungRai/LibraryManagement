

using LibraryManagment.Infrastructure;
using LibraryManagment.Persistance;
using LibraryMangment.Application;


namespace LibraryManagment.Web.Services
{
    public static class RegisterServices
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.ConfigurePersistanceServiceRegistration(configuration);
            services.ConfigureInfrastructureServicesRegistration(configuration);
            services.ConfigurationApplicationServiceRegistrationcs();
            return services;
        }
    }
}
