using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Notification.Infrastructure;

namespace Notification.API;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNotificationModule(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<NotificationDbContext>(options => options.UseNpgsql(connectionString));
        services.AddControllers().AddApplicationPart(typeof(ServiceCollectionExtensions).Assembly);
        return services;
    }
}
