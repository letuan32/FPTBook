using Domain.Enums;
using WebMVC.ViewModels.Checkouts;
using WebMVC.ViewModels.Orders;

namespace WebMVC.Services.Base;

public interface IOrderService
{
    Task<OrderCheckoutVm> GetOrderCheckoutAsync(CancellationToken cancellationToken);
    Task<int> CreateOrderAsync(CancellationToken cancellationToken);
    Task<int> UpdateOrderStatus(int orderId, OrderState state);
    Task<StoreOrderHistoryVm> GetStoreOrderHistory();
    Task<UserOrderHistoryVm> GetUserOrderHistory();
    Task<OrderDetailVm> GetOrderDetail();
}