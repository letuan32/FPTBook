namespace WebMVC.ViewModels.Cart;

public class CartUpdateVm
{
    public int Id { get; set; }
    public List<CartUpdateVm>? Items { get; set; }
}