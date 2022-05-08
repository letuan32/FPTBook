using Infrastructure.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;

namespace WebMVC.Areas.Customer.Controllers;


[Area("Customer")]
public class OrderController: Controller
{
    private readonly IOrderService _orderService;
    private readonly ICartService _cartService;
    public OrderController(IOrderService orderService, ICartService cartService)
    {
        _orderService = orderService;
        _cartService = cartService;
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

   
    [Authorize(Roles = RoleConstant.Customer)]
    [Route("/[Controller]/Confirm")]
    public async Task<IActionResult> OrderConfirm(CancellationToken cancellationToken)
    {
        var isOrderCreated = await _orderService.CreateOrderAsync(cancellationToken);
        if (isOrderCreated != 0)
        {
            await _cartService.ClearCartAsync(cancellationToken);
        }
        return View();
    }
    [Authorize(Roles = RoleConstant.Customer)]
    [Route("/[Controller]/History")]
    public async Task<IActionResult> History(CancellationToken cancellationToken)
    {
        var orderHitoriesVm = await _orderService.GetUserOrderHistoryAsync(cancellationToken);
        return View(orderHitoriesVm);
    }
    [Authorize(Roles = RoleConstant.Customer)]
    [Route("/[Controller]/Detail")]
    public async Task<IActionResult> Detail(int id,CancellationToken cancellationToken)
    {
        var orderDetail = await _orderService.GetOrderDetailAsync(id);
        return View(orderDetail);
    }
    
}