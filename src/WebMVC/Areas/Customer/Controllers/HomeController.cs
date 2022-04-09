using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Customer.Constant;
using WebMVC.Models.Pagination;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Responses;
using WebMVC.ViewModels.Books.Utils;

namespace WebMVC.Areas.Customer.Controllers;

[Area("Customer")]
public class HomeController: Controller
{
    private readonly IBookService _bookService;

    public HomeController(IBookService bookService)
    {
        _bookService = bookService;
    }

    public async Task<IActionResult> Index(GetBookIndexRequest request)
    {

        request.PageSize = ProductCatalogPagingConstant.PageSize;
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
}