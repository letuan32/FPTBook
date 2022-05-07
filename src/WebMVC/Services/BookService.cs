
using AutoMapper;
using Domain.Entities;
using Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models.Books.Requests;
using WebMVC.Models.Common;
using WebMVC.Services.Base;
using WebMVC.Utils;
using WebMVC.ViewModels.Books.Requests;
using WebMVC.ViewModels.Books.Responses;
using WebMVC.ViewModels.Books.Utils;

namespace WebMVC.Services;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;
    private readonly IFileStorageService _fileStorageService;
    private readonly IMapper _mapper;
    private readonly SignInManager<User> _signInManager;


    public BookService(ApplicationDbContext context, IMapper mapper, IFileStorageService fileStorageService, SignInManager<User> signInManager)
    {
        _context = context;
        _mapper = mapper;
        _fileStorageService = fileStorageService;
        _signInManager = signInManager;
    }

    public async Task<PaginatedList<BookIndexItemVm>> GetBookIndexAsync(GetBookIndexRequest request)
    {
      
        var queryable = _context.Books.AsQueryable();
        
        queryable = FilterQuery(request, queryable);
        // Sort
        queryable = SortingQuery(request, queryable);
        var totalCount = queryable.Count();
        queryable = PaginatedList<Book>.CreatePangingQueryAsync(queryable, request.PageNumber ?? 1,
            request.PageSize?? 5);

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
            request.PageSize??5);
    }

    public async Task<List<SelectListItem>> GetCategoryTypesAsync()
    {
        return await _context.Categories
            .Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name.ToString()
            })
            .AsNoTracking().ToListAsync();
    }

    public async Task<int> AddSingleAsync(BookAddVm bookAddVm)
    {
        
        var book = _mapper.Map<BookAddVm, Book>(bookAddVm);
        if (bookAddVm.ImageFile != null)
        {
            var bookImagePath =
                await _fileStorageService.SaveFileAsync(bookAddVm.ImageFile, ResourcePath.BookImageDirectory);
            book.ImageUrl = bookImagePath;
        }

        await _context.Books.AddAsync(book);
        var result = await _context.SaveChangesAsync();
        return result;
    }

    public async Task<int> UpdateSingleAsync(BookUpdateVm bookUpdateVm)
    {
        var book = await GetBookByIdAsync(bookUpdateVm.Id);
        book = _mapper.Map(bookUpdateVm, book);
        _context.Entry(book).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }

    public Task<int> DeleteSingleAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<BookDetailVm> GetBookDetailAsync(int id)
    {
        var book = _context.Books
            .Include(x => x.Category)
            .AsSplitQuery()
            .AsNoTracking()
            .Where(x => x.Id == id)
            .Select(x => new BookDetailVm
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CreatedDate = x.CreatedOn,
                Category = x.Category.Name,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                Quantity = x.Quantity,
                TotalSales = x.OrderItem.Count,
                CategoryId = x.CategoryId
            }).FirstOrDefault();
        ;

        return book;
    }

    public async Task<int> GetBookTotalSales(int id)
    {
        return await _context.OrderItems
            .Where(x => x.BookId == id)
            .AsNoTracking()
            .CountAsync();
    }


    public async Task<Book?> GetBookByIdAsync(int id)
    {
        return await _context.Books.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> DeleteAsync(int id)
    {
        var book = await GetBookByIdAsync(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            return await _context.SaveChangesAsync();
        }

        return 0;
    }

    public async Task<IEnumerable<BookIndexItemVm>> GetRelatedBooksByCategoryAsync(int categoryId)
    {
        // TODO: Get random related records
        var total = await _context.Books.CountAsync();
        var rand = new Random();
        var toSkip = rand.Next(1, total-5 );
        var relatedBooks = await _context.Books
            .Skip(toSkip)
            .Take(5)
            .Select(x => new BookIndexItemVm()
            {
                Id = x.Id,
                Name = x.Name, ImageUrl = x.ImageUrl,
                Price = x.Price,
                Quantity = x.Quantity,
                TotalSales = x.OrderItem.Count,
                CategoryId = x.CategoryId
            })
            .AsNoTracking()
            .ToListAsync();

        return relatedBooks;
    }

    private static IQueryable<Book> FilterQuery(GetBookIndexRequest request, IQueryable<Book> queryable)
    {
        if (request.CreatedBy.HasValue)
        {
            queryable = queryable.Where(book => book.CreatedBy == request.CreatedBy);
        }
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
                book.Name.ToLower().Contains(request.SearchString.ToLower()));

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