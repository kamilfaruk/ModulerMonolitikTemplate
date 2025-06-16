using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Web;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next) => _next = next;

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var result = JsonSerializer.Serialize(new { error = ex.Message });
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(result);
        }
    }
}
