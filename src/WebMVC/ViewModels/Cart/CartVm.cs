namespace WebMVC.ViewModels.Cart;

public class CartVm
{
    public int Id { get; set; }
    public IEnumerable<CartItemVm>? Items { get; set; } = null!;
}