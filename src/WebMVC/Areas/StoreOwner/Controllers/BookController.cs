using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebMVC.Models.Books.Responses;
using WebMVC.Models.Books.Utils;
using WebMVC.Models.Common;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Utils;

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
    public async Task<IActionResult> Index([FromQuery] GetBookIndexRequest request)
    {

       
        ViewBag.CurrentPage = request.PageNumber??1;
        // if (request.FilterOption.HasValue) ViewBag.CurrentFilterOption = request.FilterOption;

        ViewBag.NameSortParm = String.IsNullOrEmpty(request.SortOrder) ? BookIndexOption.NameSortDesc : "";
        
        // Sort ViewBag
        ViewBag.PriceSortParm = request.SortOrder == BookIndexOption.PriceSort
            ? BookIndexOption.PriceSortDesc
            : BookIndexOption.PriceSort;
        ViewBag.QuantitySortParm = request.SortOrder == BookIndexOption.PriceSort
            ? BookIndexOption.PriceSortDesc
            : BookIndexOption.PriceSort;
        ViewBag.TotalSalesSort = request.SortOrder == BookIndexOption.TotalSalesSort
            ? BookIndexOption.TotalSalesSortDesc
            : BookIndexOption.TotalSalesSort;
        var bookIndex = await _bookService.GetBookIndexAsync(request);
        
        ViewBag.CurrentSearch = request.SearchString;
        if (request.FilterOption != null)
            ViewBag.CurrentFilterOption = request.FilterOption;
        else
            ViewBag.CurretntFilterOption = "";

        ViewBag.FilterOptions = await _bookService.BookFilterOptionByCategoryAsync();
        return View(bookIndex);
    }
}