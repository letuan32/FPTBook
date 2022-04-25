using System.Net.NetworkInformation;
using System.Security.Claims;
using Infrastructure.Database;
using WebMVC.Models.Cart;
using WebMVC.Services.Base;

namespace WebMVC.Services;

public class CartService:ICartService
{
    private readonly int _userId;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ApplicationDbContext _context;

    public CartService(int userId, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
    {
        _httpContextAccessor = httpContextAccessor;
        _context = context;
        _userId = GetCurrentUserId()!.Value;
    }

    public async Task<bool> IsUserHasCart()
    {
        throw new NetworkInformationException();

    }

    public Task<int> CreateCart(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddItemToCart(CartItemAddVm request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateCartItem(CartItemUpdateVm request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<CartVm> GetCartVm(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private int? GetCurrentUserId()
    {
        var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId != null)
        {
            return int.Parse(userId);
        }
        return null;
    }
}