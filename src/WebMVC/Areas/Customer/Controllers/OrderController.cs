using Domain.Entities;
using Infrastructure.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Mails;

namespace WebMVC.Areas.Customer.Controllers;


[Area("Customer")]
public class OrderController: Controller
{
    private readonly IOrderService _orderService;
    private readonly ICartService _cartService;
    private readonly IEmailService _emailService;
    private readonly UserManager<User> _userManager;
    public OrderController(IOrderService orderService, ICartService cartService, IEmailService emailService, UserManager<User> userManager)
    {
        _orderService = orderService;
        _cartService = cartService;
        _emailService = emailService;
        _userManager = userManager;
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
            var email = User.Identity?.Name ?? "";
            var emailRequest = new SendEmailRequest()
            {
                To = new List<string>() { email },
                Subject = "Confirm order",
                Body =
                    "FPT Book đã nhận được yêu cầu đặt hàng của bạn và đang xử lý nhé. Bạn sẽ nhận được thông báo tiếp theo khi đơn hàng đã sẵn sàng được giao. "

            };
            _emailService.SendEmail(emailRequest);
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