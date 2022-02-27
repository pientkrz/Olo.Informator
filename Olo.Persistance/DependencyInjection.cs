using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Olo.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OloDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OpolskaLigaOrlika")));

            services.AddScoped<OloDbContext>(provider => provider.GetService<OloDbContext>());

            return services;
        }
    }
}