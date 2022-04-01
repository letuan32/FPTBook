using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Models.Books.Requests;
using WebMVC.Models.Books.Responses;
using WebMVC.Models.Books.Utils;
using WebMVC.Models.Common;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;

namespace WebMVC.Services;

public class BookService:IBookService
{
    private readonly ApplicationDbContext _context;
   

    public BookService(ApplicationDbContext context)
    {
        _context = context;
    
    }

    public async Task<PaginatedList<BookIndexVm>> GetBookIndexAsync(GetBookIndexRequest request)
    {
        var queryable = _context.Book.AsQueryable();
       // Check filter by category option
        if (request.FilterOption.HasValue)
        {
            queryable = queryable.Where(book => book.CategoryId == request.FilterOption.Value);
        }
        
        // Check search string
        if (String.IsNullOrEmpty(request.SearchString))
        {
            request.Page = 1;
        }
        else
        {
            request.SearchString = request.CurrentSearch;
        }
        // Filter by search string
        if (!String.IsNullOrEmpty(request.SearchString))
        {
            queryable = queryable.Where(book =>
                book.Name.Contains(request.SearchString, StringComparison.CurrentCultureIgnoreCase));
        }
        
        // Sort
        switch (request.SortOrder)
        {
            
        }
        var totalCount = queryable.Count();
        queryable = PaginatedList<Book>.CreatePangingQueryAsync(queryable, request.Page??1, BookPagingOption.PageSize);

       
        var bookIndexVms = await queryable.Select(x => new BookIndexVm
        {
            Id = x.Id,
            Name = x.Name,
            Price = x.Price,
            ImageUrl = x.ImageUrl,
            Quantity = x.Quantity,
            // TotalSales = GetBookTotalSales(x.Id).Result

        }).ToListAsync();

        return await PaginatedList<BookIndexVm>.GetPagingResult(bookIndexVms, totalCount, request.Page ?? 1,
            BookPagingOption.PageSize);
    }

    public async Task<List<SelectListItem>> BookFilterOptionByCategoryAsync()
    {
        return await _context.Category
            .Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name.ToString()
            })
            .AsNoTracking().ToListAsync();
    }

    public Task<int> AddSingleAsync(BookAddVm bookAddVm)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateSingleAsync(BookUpdateVm bookUpdateVm)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteSingleAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<BookDetailVm> GetBookDetailAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetBookTotalSales(int id)
    {
        return await _context.OrderItem
            .Where(x => x.BookId == id)
            .AsNoTracking()
            .CountAsync();

    }
}