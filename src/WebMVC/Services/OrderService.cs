using System.Security.Claims;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Cart;
using WebMVC.ViewModels.Checkouts;
using WebMVC.ViewModels.Orders;
using WebMVC.ViewModels.Orders.StoreOwner;

namespace WebMVC.Services;

public class OrderService:IOrderService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly SignInManager<User> _signInManager;
    private int UserId { get; }
    

    public OrderService(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _context = context;
        _signInManager = signInManager;
        UserId = GetCurrentUserId()!.Value;
        
    }
    public async Task<OrderCheckoutVm> GetOrderCheckoutAsync(CancellationToken cancellationToken)
    {
        var cartId = GetUserCartId();
        var items = await _context.CartItems
            .Where(c => c.CartId == cartId)
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

    public async Task<int> CreateOrderAsync(CancellationToken cancellationToken)
    {
        var cartId = GetUserCartId();
        var cartItems = await _context.CartItems
            .Where(c => c.CartId == cartId)
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



        var totalPrice = cartItems.Sum(x => x.Price);
        var orderItems = cartItems.Select(x => new OrderItem()
        {
            BookId = x.BookId,
            Quantity = x.Quantity,
        }).ToList();


        var Order = new Order()
        {
            CustomerId = UserId,
            OrderDate = DateTime.Now,
            State = OrderState.Ordering,
            OrderItems = orderItems,
            Total = totalPrice
        };
        await _context.AddAsync(Order);
        return await _context.SaveChangesAsync();
        
    }

    public Task<int> UpdateOrderStatus(int orderId, OrderState state)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<StoreOrderHistoryItemVm>> GetStoreOrderHistoryAsync()
    {
        var orderItems = await _context.Orders
            .Include(x => x.OrderItems)
            .ThenInclude(item => item.Book)
            .Where(x=>x.OrderItems.Any(x=>x.Book.CreatedBy == UserId))
            .Join(_context.Users, order => order.CustomerId, user => user.Id,
                ((order, user) => new {order,user} ))
            .Select(x => new StoreOrderHistoryItemVm()
            {
                OrderId = x.order.Id,
                TotalItems = x.order.OrderItems.Count,
                OrderedDate = x.order.OrderDate,
                Price = x.order.Total,
                Address = x.user.Address,
                CustomerEmail = x.user.Email,
            }).ToListAsync();

        return orderItems;
    }

    public async Task<IEnumerable<OrderHistoryItemVm>> GetUserOrderHistoryAsync(CancellationToken cancellationToken)
    {

        var orderItems = await _context.Orders
            .AsNoTracking()
            .Include(x => x.OrderItems)
            .Select(x => new OrderHistoryItemVm()
            {
                OrderId = x.Id,
                TotalItems = x.OrderItems.Count,
                OrderedDate = x.OrderDate,
                Price = x.Total
            }).ToListAsync(cancellationToken: cancellationToken);


       
        return orderItems;
    }

    public async Task<OrderDetailVm> GetOrderDetailAsync(int id)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        var orderItems = await _context.OrderItems
            .Where(o => o.OrderId == id)
            .Join(_context.Books, orderItem => orderItem.BookId, book => book.Id,
                ((item, book) => new { item, book }))
            .Select(x => new OrderItemVm()
            {
                Id = x.item.Id,
                BookId = x.book.Id,
                ImageUrl = x.book.ImageUrl,
                Name = x.book.Name,
                Quantity = x.item.Quantity,
                Price = x.item.Quantity*x.book.Price,
            }).ToListAsync();

        var orderDetailVm = new OrderDetailVm()
        {
            OrderedDate = order.OrderDate,
            TotalPrice = order.Total,
            Items = orderItems,
        };
        return orderDetailVm;
    }

    public async Task<StoreOrderDetailVm> GetStoreOrderDetailAsync(int id)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        var customer = await _context.Users.FirstOrDefaultAsync(x => x.Id == order.CustomerId);
        var orderItems = await _context.OrderItems
            .Where(o => o.OrderId == id && o.Book.CreatedBy == UserId)
            .Join(_context.Books, orderItem => orderItem.BookId, book => book.Id,
                ((item, book) => new { item, book }))
            .Select(x => new OrderItemVm()
            {
                Id = x.item.Id,
                BookId = x.book.Id,
                ImageUrl = x.book.ImageUrl,
                Name = x.book.Name,
                Quantity = x.item.Quantity,
                Price = x.item.Quantity*x.book.Price,
            }).ToListAsync();

        var orderDetailVm = new StoreOrderDetailVm()
        {
            OrderedDate = order.OrderDate,
            TotalPrice = orderItems.Sum(x=>x.Price),
            Items = orderItems,
            Address = customer.Address,
            CustomerEmail = customer.Email
        };
        return orderDetailVm;
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