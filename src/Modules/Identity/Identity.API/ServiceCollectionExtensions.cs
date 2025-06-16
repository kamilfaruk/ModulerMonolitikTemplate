using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Identity.Infrastructure;

namespace Identity.API;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIdentityModule(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IdentityDbContext>(options => options.UseNpgsql(connectionString));
        services.AddControllers().AddApplicationPart(typeof(ServiceCollectionExtensions).Assembly);
        return services;
    }
}
