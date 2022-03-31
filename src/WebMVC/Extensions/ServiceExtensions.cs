using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Extensions;

public static class ServiceExtensions
{
    public static void AddDbContext(string? connectionUrl, WebApplicationBuilder webApplicationBuilder)
    {
        var databaseUri = new Uri(connectionUrl);
        string dbName = databaseUri.LocalPath.TrimStart('/');
        string[] userInfo = databaseUri.UserInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);
        var connectionString =
            $"User ID={userInfo[0]};Password={userInfo[1]};Host={databaseUri.Host};Port={databaseUri.Port};Database={dbName};Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";
        webApplicationBuilder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
           
    
}