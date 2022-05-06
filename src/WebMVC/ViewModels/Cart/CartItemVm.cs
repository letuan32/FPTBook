namespace WebMVC.ViewModels.Cart;

public class CartItemVm
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    
}