using WebMVC.Models.Cart;

namespace WebMVC.Services.Base;

public interface ICartService
{
    Task<bool> IsUserHasCart();
    Task<int> CreateCart(CancellationToken cancellationToken);
    Task<int> AddItemToCart(CartItemAddVm request, CancellationToken cancellationToken);
    Task<int> UpdateCartItem(CartItemUpdateVm request, CancellationToken cancellationToken);
    Task<CartVm> GetCartVm(CancellationToken cancellationToken);
}