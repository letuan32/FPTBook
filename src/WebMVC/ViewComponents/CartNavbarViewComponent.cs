using System.Security.AccessControl;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Responses;

namespace WebMVC.ViewComponents;

public class CartNavbarViewComponent:ViewComponent
{
   
    private readonly SignInManager<User> _signInManager;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    public CartNavbarViewComponent( SignInManager<User> signInManager, IServiceScopeFactory serviceScopeFactory)
    {
        _signInManager = signInManager;
        _serviceScopeFactory = serviceScopeFactory;
    }
    
    public async Task<IViewComponentResult> InvokeAsync(int categoryId)
    {
        var cartItemsCount = 0;
        if (_signInManager.IsSignedIn(Request.HttpContext.User))
        {
            using IServiceScope scope = _serviceScopeFactory.CreateScope();
            var cartService = scope.ServiceProvider.GetRequiredService<ICartService>();
            cartItemsCount = await cartService.GetTotalCartItems();
        }
        return View(cartItemsCount);
    }
    
}