using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kookweb.Core.Interfaces;
using Kookweb.Core.Services;
using Kookweb.DataAccess.Repository.Interface;

namespace Kookweb.Core
{
    public static class Register
    {
        public static void ConfigureBaseServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICountryService, CountryService>();
        }
        public static void ConfigureEFServices(IServiceCollection services, IConfiguration configuration)
        {
            Kookweb.DataAccess.EF.Register.ConfigureServices(services, configuration);
        }
    }
}