using Domain.Enums;
using WebMVC.ViewModels.Checkouts;
using WebMVC.ViewModels.Orders;
using WebMVC.ViewModels.Orders.StoreOwner;

namespace WebMVC.Services.Base;

public interface IOrderService
{
    Task<OrderCheckoutVm> GetOrderCheckoutAsync(CancellationToken cancellationToken);
    Task<int> CreateOrderAsync(CancellationToken cancellationToken);
    Task<IEnumerable<StoreOrderHistoryItemVm>> GetStoreOrderHistoryAsync();
    Task<IEnumerable<OrderHistoryItemVm>> GetUserOrderHistoryAsync(CancellationToken cancellationToken);
    Task<OrderDetailVm> GetOrderDetailAsync(int id);
    
    Task<StoreOrderDetailVm> GetStoreOrderDetailAsync(int id);
}