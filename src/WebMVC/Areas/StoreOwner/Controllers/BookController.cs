using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebMVC.Models.Books.Responses;
using WebMVC.Models.Common;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;

namespace WebMVC.Areas.StoreOwner.Controllers;


[Area("StoreOwner")]
public class BookController:Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(GetBookIndexRequest request)
    {

       
        ViewBag.CurrentPage = request.Page??1;
        return View(await _bookService.GetBookIndexAsync(request));
    }
}