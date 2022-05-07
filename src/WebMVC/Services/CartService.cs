using System.Security.Claims;
using Domain.Entities;
using Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Cart;

namespace WebMVC.Services;

public class CartService : ICartService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CartService(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
    {
        _httpContextAccessor = httpContextAccessor;
        _context = context;
        UserId = GetCurrentUserId()!.Value;
        CartId = GetUserCartId();
    }

    private int UserId { get; }
    private int CartId { get; }

    public async Task<bool> IsUserHasCartAsync()
    {
        var isUserHasCart = await _context.Carts.AnyAsync(x => x.UserId == UserId);
        return isUserHasCart;
    }

    public async Task<int> CreateCartAsync(CancellationToken cancellationToken)
    {
        await _context.Carts.AddAsync(new Cart
        {
            UserId = UserId
        }, cancellationToken);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<int> AddItemToCartAsync(CartItemAddVm request, CancellationToken cancellationToken)
    {
        var itemInCart = await ItemInCartOrDefault(request.ProductId);
        if (itemInCart is not null)
        {
            itemInCart.Quantity += request.Quantity;
            return await _context.SaveChangesAsync(cancellationToken);
        }

        await _context.CartItems.AddAsync(new CartItem
        {
            CartId = CartId,
            BookId = request.ProductId,
            Quantity = request.Quantity
        }, cancellationToken);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<int> UpdateCartItemAsync(CartItemUpdateVm request, CancellationToken cancellationToken)
    {
        var itemInCart = await _context.CartItems
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (itemInCart != null)
        {
            itemInCart.Quantity = request.Quantity;
            if (itemInCart.Quantity == 0)
            {
                _context.CartItems.Remove(itemInCart);

            }
        }
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<int> RemoveItemInCartAsync(int itemId, CancellationToken cancellationToken)
    {
        var item = await _context.CartItems.FindAsync(itemId);
        if (item != null) _context.CartItems.Remove(item);
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<int> GetTotalCartItems()
    {
        return await _context.CartItems
            .CountAsync(x => x.CartId == CartId);
    }

    public async Task<CartVm> GetCartAsync(CancellationToken cancellationToken)
    {
        var items = await _context.CartItems
            .Where(c => c.CartId == CartId)
            .Join(_context.Books, cartItem => cartItem.BookId, book => book.Id,
                (cartItem, book) => new { cartItem, book })
            .Select(t => new CartItemVm
            {
                Id = t.cartItem.Id,
                BookId = t.book.Id,
                ImageUrl = t.book.ImageUrl,
                Name = t.book.Name,
                Price = t.book.Price * t.cartItem.Quantity,
                Quantity = t.cartItem.Quantity
            })
            .AsNoTracking()
            .ToListAsync(cancellationToken);


        return new CartVm
        {
            Id = CartId,
            Items = items
        };
    }

    private int? GetCurrentUserId()
    {
        var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId != null) return int.Parse(userId);
        return null;
    }

    private async Task<CartItem?> ItemInCartOrDefault(int productId)
    {
        var itemInCart = await _context.CartItems
            .FirstOrDefaultAsync(x => x.CartId == CartId && x.BookId == productId);
        return itemInCart;
    }

    private int GetUserCartId()
    {
        var cart = _context.Carts
            .First(x => x.UserId == UserId);
        return cart.Id;
    }
}