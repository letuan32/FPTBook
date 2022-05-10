using Infrastructure.Database;
using Infrastructure.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Cart;

namespace WebMVC.Areas.Customer.Controllers;

[Area("Customer")]
[Authorize(Roles = RoleConstant.Customer)]
public class CartController : Controller
{
    private readonly ICartService _cartService;
    private readonly ApplicationDbContext _context;
    
    public CartController(ICartService cartService, ApplicationDbContext context)
    {
        _cartService = cartService;
        _context = context;
    }

    [HttpGet]
    [Route("/Cart")]
    
    public async Task<IActionResult> GetCart(CancellationToken cancellationToken)
    {
        var items = await _cartService.GetCartAsync(cancellationToken);
        return View("Index",items);
    }

    [HttpPost]
    public async Task<IActionResult> AddItemToCart([FromBody]CartItemAddVm request, CancellationToken cancellationToken)
    {
        var book = _context.Books.Find(request.ProductId);
        if (book.Quantity == 0)
        {
            return BadRequest();
        }
        var response = await _cartService.AddItemToCartAsync(request, cancellationToken);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateItem([FromBody]CartItemUpdateVm request, CancellationToken cancellationToken)
    {
        var item = await _context.CartItems.FindAsync(request.Id);

        var book = await _context.Books.FindAsync(item.BookId);

        if (request.Quantity > book.Quantity)
        {
            return BadRequest();
        }
        
        var isUpdated = await _cartService.UpdateCartItemAsync(request, cancellationToken);
        return Ok();
    }

    public IActionResult RefreshViewComponent()
    {
        return ViewComponent("CartNavbar");
    }
}