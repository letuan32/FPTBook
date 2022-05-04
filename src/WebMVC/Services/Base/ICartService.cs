using WebMVC.Models.Cart;
using WebMVC.ViewModels.Cart;

namespace WebMVC.Services.Base;

public interface ICartService
{
    Task<bool> IsUserHasCartAsync();
    Task<int> CreateCartAsync(CancellationToken cancellationToken);
    Task<int> AddItemToCartAsync(CartItemAddVm request, CancellationToken cancellationToken);
    Task<int> UpdateCartItemAsync(CartItemUpdateVm request, CancellationToken cancellationToken);
    Task<int> RemoveItemInCartAsync(int itemId, CancellationToken cancellationToken);
    Task<int> GetTotalCartItems();
    Task<CartVm> GetCartAsync(CancellationToken cancellationToken);
}