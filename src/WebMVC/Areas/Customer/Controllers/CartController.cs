using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Cart;

namespace WebMVC.Areas.Customer.Controllers;

[Area("Customer")]
public class CartController : Controller
{
    private readonly ICartService _cartService;
    
    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCart(CancellationToken cancellationToken)
    {
        var items = await _cartService.GetCartAsync(cancellationToken);
        return View("Index",items);
    }

    [HttpPost]
    public async Task<IActionResult> AddItemToCart([FromBody]CartItemAddVm request, CancellationToken cancellationToken)
    {
        var response = await _cartService.AddItemToCartAsync(request, cancellationToken);
        return Ok();
    }

    public IActionResult RefreshViewComponent()
    {
        return ViewComponent("CartNavbar");
    }
}