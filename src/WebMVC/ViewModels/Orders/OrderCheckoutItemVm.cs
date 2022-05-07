namespace WebMVC.ViewModels.Checkouts;

public class OrderCheckoutItemVm
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }
    public string ImageUrl { get; set; }
    
}