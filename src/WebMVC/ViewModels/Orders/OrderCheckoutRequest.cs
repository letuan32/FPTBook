namespace WebMVC.ViewModels.Orders;

public class OrderCheckoutRequest
{
    public List<OrderCheckoutItemsRequest>? OrderItems { get; set; }
}