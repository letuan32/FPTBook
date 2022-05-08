
using Infrastructure.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;

namespace WebMVC.Areas.StoreOwner.Controllers;

[Area("StoreOwner")]
[Authorize(Roles = RoleConstant.StoreOwner)]
public class OrderController:Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [ActionName("Index")]
    public async Task<IActionResult> GetStoreOrderHistoryAsync()
    {

        var orderHistories = await _orderService.GetStoreOrderHistoryAsync();
        return View(orderHistories);
    }

    public async Task<IActionResult> Detail(int id)
    {

        var orderDetail = await _orderService.GetStoreOrderDetailAsync(id);
        return View(orderDetail);
    }
}