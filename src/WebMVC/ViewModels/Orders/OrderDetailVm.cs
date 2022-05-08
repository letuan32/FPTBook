using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using WebMVC.ViewModels.Cart;

namespace WebMVC.ViewModels.Orders;

public class OrderDetailVm
{
    public ICollection<OrderItemVm> Items { get; set; }

    public DateTime OrderedDate { get; set; }
    public int TotalPrice { get; set; }
}

public class OrderItemVm
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}

