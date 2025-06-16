using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Location.Infrastructure;

namespace Location.API;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLocationModule(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<LocationDbContext>(options => options.UseNpgsql(connectionString));
        services.AddControllers().AddApplicationPart(typeof(ServiceCollectionExtensions).Assembly);
        return services;
    }
}
