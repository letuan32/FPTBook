using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Services;

namespace WebMVC.Areas.StoreOwner.Controllers;

[Area("StoreOwner")]

public class HomeController : Controller
{
    
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}