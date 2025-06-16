using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BuildingBlocks.Web;
using Identity.API;
using Location.API;
using Notification.API;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default") ?? "";

builder.Services.AddControllers();
builder.Services.AddIdentityModule(connectionString);
builder.Services.AddLocationModule(connectionString);
builder.Services.AddNotificationModule(connectionString);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseGlobalExceptionHandling();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
