using Microsoft.AspNetCore.Builder;

namespace BuildingBlocks.Web;

public static class WebApplicationExtensions
{
    public static IApplicationBuilder UseGlobalExceptionHandling(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
