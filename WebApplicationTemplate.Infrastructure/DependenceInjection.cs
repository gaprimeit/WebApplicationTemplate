using Cheap.Flights.Business.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationTemplate.Infrastructure.Services;

namespace WebApplicationTemplate.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddScoped<ICacheService, MemoryCacheService>();

            return services;
        }
    }
}
