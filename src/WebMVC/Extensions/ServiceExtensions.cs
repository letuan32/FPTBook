using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using WebMVC.Services;
using WebMVC.Services.Base;

namespace WebMVC.Extensions;

public static class ServiceExtensions
{
    public static void AddDbContext(string? connectionUrl, WebApplicationBuilder builder)
    {
        var databaseUri = new Uri(connectionUrl);
        var dbName = databaseUri.LocalPath.TrimStart('/');
        var userInfo = databaseUri.UserInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);
        var connectionString =
            $"User ID={userInfo[0]};Password={userInfo[1]};Host={databaseUri.Host};Port={databaseUri.Port};Database={dbName};Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
    }

    public static void AddServices(WebApplicationBuilder builder)
    {
        builder.Services
            .AddScoped<IServiceBase, CategoryService>();
        builder.Services.AddScoped<IBookService, BookService>();
        builder.Services.AddScoped<ICartService, CartService>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        // Automapper
        builder.Services.AddAutoMapper(typeof(Program).Assembly);
        builder.Services.AddScoped<IFileStorageService, FileStorageService>();
    }
}