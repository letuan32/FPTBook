using Domain.Enums;
using WebMVC.ViewModels.Checkouts;
using WebMVC.ViewModels.Orders;

namespace WebMVC.Services.Base;

public interface IOrderService
{
    Task<OrderCheckoutVm> GetOrderCheckoutAsync(OrderCheckoutRequest request, CancellationToken cancellationToken);
    Task<int> CreateOrderAsync(OrderCheckoutRequest request, CancellationToken cancellationToken);
    Task<int> UpdateOrderStatus(int orderId, OrderState state);
    Task<StoreOrderHistoryVm> GetStoreOrderHistory();
    Task<UserOrderHistoryVm> GetUserOrderHistory();
    Task<OrderDetailVm> GetOrderDetail();
}