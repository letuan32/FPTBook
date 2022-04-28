using WebMVC.ViewModels.Checkouts;

namespace WebMVC.ViewModels.Orders;

public class OrderCheckoutVm
{
    public string Address { get; set; }
    public List<OrderCheckoutItemVm> CheckoutItemVms { get; set; }
    public int TotalPrice { get; set; }
}