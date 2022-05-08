using System.ComponentModel.DataAnnotations;

namespace WebMVC.ViewModels.Orders;

public class OrderHistoryItemVm
{
    public int OrderId { get; set; }
    [Display(Name = "Total Item")]
    public int TotalItems { get; set; }
    
    [Display(Name = "Total Price")]
    public int Price{ get; set; }
    
    [Display(Name = "Ordered Date")]
    public DateTime OrderedDate{ get; set; }
    
    
    
}