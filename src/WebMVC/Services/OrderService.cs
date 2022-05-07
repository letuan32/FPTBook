using System.Security.Claims;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Checkouts;
using WebMVC.ViewModels.Orders;

namespace WebMVC.Services;

public class OrderService:IOrderService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly SignInManager<User> _signInManager;
    private int UserId { get; }
    private int CartId { get; }

    public OrderService(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _context = context;
        _signInManager = signInManager;
        UserId = GetCurrentUserId()!.Value;
        CartId = GetUserCartId();
    }
    public async Task<OrderCheckoutVm> GetOrderCheckoutAsync(CancellationToken cancellationToken)
    {
        var items = await _context.CartItems
            .Where(c => c.CartId == CartId)
            .Join(_context.Books, cartItem => cartItem.BookId, book => book.Id,
                (cartItem, book) => new { cartItem, book })
            .Select(t => new OrderCheckoutItemVm()
            {
                Id = t.cartItem.Id,
                BookId = t.book.Id,
                ImageUrl = t.book.ImageUrl,
                Name = t.book.Name,
                Quantity = t.cartItem.Quantity,
                TotalPrice = t.book.Price*t.cartItem.Quantity,
            })
            .AsNoTracking()
            .ToListAsync(cancellationToken);
        var user = _context.Users.FirstOrDefault(x => x.Id == UserId);

        var orderCheckOutVm = new OrderCheckoutVm()
        {
            Name = user.UserName,
            Address = user.Address,
            Email = user.Email,
            CheckoutItemVms = items,
            TotalPrice = items.Sum(x => x.TotalPrice)
        };
        return orderCheckOutVm;

    }

    public Task<int> CreateOrderAsync(OrderCheckoutRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateOrderStatus(int orderId, OrderState state)
    {
        throw new NotImplementedException();
    }

    public Task<StoreOrderHistoryVm> GetStoreOrderHistory()
    {
        throw new NotImplementedException();
    }

    public Task<UserOrderHistoryVm> GetUserOrderHistory()
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetailVm> GetOrderDetail()
    {
        throw new NotImplementedException();
    }
    private int? GetCurrentUserId()
    {
        var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId != null) return int.Parse(userId);
        return null;
    }
    private int GetUserCartId()
    {
        var cart = _context.Carts
            .First(x => x.UserId == UserId);
        return cart.Id;
    }
}