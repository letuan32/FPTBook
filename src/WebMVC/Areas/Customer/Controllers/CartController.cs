using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;

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
        return Ok(items);
    }
}