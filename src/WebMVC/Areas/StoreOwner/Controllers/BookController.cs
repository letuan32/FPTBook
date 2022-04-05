using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Pagination;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Responses;
using WebMVC.ViewModels.Books.Utils;

namespace WebMVC.Areas.StoreOwner.Controllers;

[Area("StoreOwner")]
public class BookController : Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> Index([FromQuery] GetBookIndexRequest request)
    {
        var books = await _bookService.GetBookIndexAsync(request);
        var vm = new BookIndexVm
        {
            BookItems = books,
            Categories = await _bookService.GetCategoryTypesAsync(),
            NameSortParm = string.IsNullOrEmpty(request.SortOption) ? BookIndexOption.NameSortDesc : "",
            PriceSortParm = request.SortOption == BookIndexOption.PriceSort
                ? BookIndexOption.PriceSortDesc
                : BookIndexOption.PriceSort,
            QuantitySortParm = request.SortOption == BookIndexOption.QuantitySort
                ? BookIndexOption.QuantitySortDesc
                : BookIndexOption.QuantitySort,
            TotalSalesSortParm = request.SortOption == BookIndexOption.TotalSalesSort
                ? BookIndexOption.TotalSalesSortDesc
                : BookIndexOption.TotalSalesSort,
            CurrentSearchString = request.SearchString,
            CurrentCategoryFilter = request.FilterOption,
            CurrentSort = request.SortOption,
            PaginationInfo = new PaginationInfo
            {
                ActualPage = request.PageNumber ?? 1,
                TotalItems = books.TotalItems,
                ItemsPerPage = books.Count,
                TotalPages = books.TotalPages,
                Next = books.HasNextPage,
                Previous = books.HasPreviousPage
            }
        };
        return View(vm);
    }


    public async Task<IActionResult> Create()
    {
        var categories = await _bookService.GetCategoryTypesAsync();
        var bookAddVm = new BookAddVm
        {
            Categories = categories
        };
        return View("Book/Create", bookAddVm);
    }

    [HttpPost]
    [RequestSizeLimit(200000)]
    public async Task<IActionResult> Create([FromForm] BookAddVm bookAddVm)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var isCreated = await _bookService.AddSingleAsync(bookAddVm);
                if (isCreated == 1) return RedirectToAction("Index");

                return View("Book/Create", bookAddVm);
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("Error",
                $"It was not possible to create a new Book, please try later on ({ex.GetType().Name} - {ex.Message})");
        }

        return View("Book/Create", bookAddVm);
    }
}