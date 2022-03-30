using System.Diagnostics;
using Domain.Entities;
using Infrastructure.Database;
using Infrastructure.SeedData;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;
var connectionString = string.Empty;
if (env.IsDevelopment())
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(connectionString));
}
else
{
    string? connectionUrl = Environment.GetEnvironmentVariable("HEROKU_DATABASE_URL");
    
        var databaseUri = new Uri(connectionUrl);
        string db = databaseUri.LocalPath.TrimStart('/');
        string[] userInfo = databaseUri.UserInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);
        connectionString =
            $"User ID={userInfo[0]};Password={userInfo[1]};Host={databaseUri.Host};Port={databaseUri.Port};Database={db};Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.ListenAnyIP(Int32.Parse(Environment.GetEnvironmentVariable("PORT"))); // to listen for incoming http connection on port 5001
        });
}


builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
// Extentions
// builder.Services
//     .AddDatabase(builder.Configuration);


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

// Apply migration at runtime
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Store",
        areaName: "Store",
        pattern: "Store/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});
app.Run();