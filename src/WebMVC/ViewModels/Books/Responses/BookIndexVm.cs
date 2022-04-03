using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Models.Pagination;

namespace WebMVC.ViewModels.Books.Responses;

public class BookIndexVm
{
    public IEnumerable<BookIndexItemVm> BookItems { get; set; }
    public IEnumerable<SelectListItem> Categories { get; set; }
    public int? CurrentCategoryFilter { get; set; }
    public string CurrentSort { get; set; }
    public string CurrentSearchString { get; set; }
    public PaginationInfo PaginationInfo { get; set; }
    public string NameSortParm { get; set; }
    public string PriceSortParm { get; set; }
    public string QuantitySortParm { get; set; }
    public string TotalSalesSortParm { get; set; }
}