using Microsoft.AspNetCore.Mvc;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Responses;

namespace WebMVC.ViewComponents;

public class RelatedProductsViewComponent: ViewComponent
{
    private readonly IBookService _bookService;

    public RelatedProductsViewComponent(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    public async Task<IViewComponentResult> InvokeAsync(int categoryId)
    {
        var items = await GetItemsAsync(categoryId);
        return View(items);
    }
    
    private async Task<IEnumerable<BookIndexItemVm>> GetItemsAsync(int categoryId)
    {
        return await _bookService.GetRelatedBooksByCategoryAsync(categoryId);
    }
}