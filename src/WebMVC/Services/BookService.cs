using Domain.Entities;
using Infrastructure.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models.Books.Requests;
using WebMVC.Models.Books.Responses;
using WebMVC.Models.Common;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Responses;
using WebMVC.ViewModels.Books.Utils;

namespace WebMVC.Services;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;


    public BookService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PaginatedList<BookIndexItemVm>> GetBookIndexAsync(GetBookIndexRequest request)
    {
        var queryable = _context.Book.AsQueryable();

        queryable = FilterQuery(request, queryable);
        // Sort
        queryable = SortingQuery(request, queryable);
        var totalCount = queryable.Count();
        queryable = PaginatedList<Book>.CreatePangingQueryAsync(queryable, request.PageNumber ?? 1,
            BookIndexOption.PageSize);

        var bookIndexVms = await queryable.Select(x => new BookIndexItemVm
        {
            Id = x.Id,
            Name = x.Name,
            Price = x.Price,
            ImageUrl = x.ImageUrl,
            Quantity = x.Quantity,
            TotalSales = x.OrderItem.Count
        }).ToListAsync();

        return await PaginatedList<BookIndexItemVm>.GetPagingResult(bookIndexVms, totalCount, request.PageNumber ?? 1,
            BookIndexOption.PageSize);
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

    private static IQueryable<Book> FilterQuery(GetBookIndexRequest request, IQueryable<Book> queryable)
    {
        if (request.FilterOption.HasValue)
            queryable = queryable.Where(book => book.CategoryId == request.FilterOption.Value);

        // Check search string
        if (!string.IsNullOrEmpty(request.SearchString))
            request.PageNumber = 1;
        else
            request.SearchString = request.CurrentSearch;

        // Filter by search string
        if (!string.IsNullOrEmpty(request.SearchString))
            queryable = queryable.Where(book =>
                book.Name.ToLower().Contains(request.SearchString));

        return queryable;
    }

    private static IQueryable<Book> SortingQuery(GetBookIndexRequest request, IQueryable<Book> queryable)
    {
        switch (request.SortOption)
        {
            case BookIndexOption.NameSort:
                queryable = queryable.OrderBy(x => x.Name);
                break;
            case BookIndexOption.NameSortDesc:
                queryable = queryable.OrderByDescending(x => x.Name);
                break;

            case BookIndexOption.PriceSort:
                queryable = queryable.OrderBy(x => x.Price);
                break;
            case BookIndexOption.PriceSortDesc:
                queryable = queryable.OrderByDescending(x => x.Price);
                break;
            case BookIndexOption.QuantitySort:
                queryable = queryable.OrderBy(x => x.Quantity);
                break;
            case BookIndexOption.QuantitySortDesc:
                queryable = queryable.OrderByDescending(x => x.Quantity);
                break;
            case BookIndexOption.TotalSalesSort:
                queryable = queryable.OrderBy(x => x.OrderItem.Count);
                break;
            default:
                queryable = queryable.OrderBy(x => x.Name);
                break;
        }

        return queryable;
    }
}