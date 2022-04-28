using Domain.Enums;

namespace WebMVC.ViewModels.Orders;

public class UpdateOrderStateRequest
{
    public int OrderId { get; set; }
    public OrderState State { get; set; }
}