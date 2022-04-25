namespace WebMVC.Models.Cart;

public class CartVm
{
    public int Id { get; set; }
    public IEnumerable<CartItemVm> CartItems { get; set; } = null!;
}