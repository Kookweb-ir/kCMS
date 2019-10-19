using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kookweb.DataAccess.EF.Context;
using Kookweb.DataAccess.EF.Repository;
using Kookweb.DataAccess.Repository.Interface;

namespace Kookweb.DataAccess.EF
{
    public static class Register
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>                            
                options.UseSqlServer(configuration.GetConnectionString("readConnection"))
            );
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        }
    }
}