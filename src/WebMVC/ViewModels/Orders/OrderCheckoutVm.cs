using WebMVC.ViewModels.Checkouts;

namespace WebMVC.ViewModels.Orders;

public class OrderCheckoutVm
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<OrderCheckoutItemVm> CheckoutItemVms { get; set; }
    public int TotalPrice { get; set; }
}