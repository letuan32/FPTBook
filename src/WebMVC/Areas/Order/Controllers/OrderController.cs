using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;

namespace WebMVC.Areas.Order.Controllers;


[Area("Order")]
public class OrderController: Controller
{
    private readonly IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    [ActionName("Index")]
    [Route("[controller]")]
    [Route("[controller]/Index")]

    public async Task<IActionResult> GetOrderCheckOutAsync(CancellationToken cancellationToken)
    {
        var orderVm = await _orderService.GetOrderCheckoutAsync(cancellationToken);
        return View("Index",orderVm);
    }

    public async Task<IActionResult> OrderConfirm(CancellationToken cancellationToken)
    {
        return View();
    }
}