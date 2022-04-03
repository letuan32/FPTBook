using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Models.Books.Requests;
using WebMVC.Models.Books.Responses;
using WebMVC.Models.Common;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Responses;

namespace WebMVC.Services.Base;

public interface IBookService
{
    Task<PaginatedList<BookIndexItemVm>> GetBookIndexAsync(GetBookIndexRequest request);

    Task<List<SelectListItem>> BookFilterOptionByCategoryAsync();
    Task<int> AddSingleAsync(BookAddVm bookAddVm);
    Task<int> UpdateSingleAsync(BookUpdateVm bookUpdateVm);
    Task<int> DeleteSingleAsync(int id);
    Task<BookDetailVm> GetBookDetailAsync(int id);
    Task<int> GetBookTotalSales(int id);
}