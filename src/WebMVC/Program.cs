
using System.Reflection;
using System.Security.Policy;
using Domain.Entities;
using Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebMVC.Extensions;


var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

string? connectionUrl;
if (env.IsDevelopment())
{
    connectionUrl = builder.Configuration.GetConnectionString("DefaultConnectionUrl");
}
else
{
        connectionUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.ListenAnyIP(Int32.Parse(Environment.GetEnvironmentVariable("PORT")));
        });
}
ServiceExtensions.AddDbContext(connectionUrl, builder);
ServiceExtensions.AddServices(builder);

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI();


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

// Routing
app.UseEndpoints(endpoints =>
{
    
    // endpoints.MapControllerRoute(
    //     name: "MyArea",
    //     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapAreaControllerRoute(
        name: "StoreOwner",
        areaName: "StoreOwner",
        pattern: "StoreOwner/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapAreaControllerRoute(
        name: "Customer",
        areaName: "Customer",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    // endpoints.MapControllerRoute(
    //     name: "default",
    //     pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllers();    
    endpoints.MapRazorPages();

    
});

app.MapRazorPages();
app.Run();