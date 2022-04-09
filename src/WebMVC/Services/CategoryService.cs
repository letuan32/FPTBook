using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Categories.Responses;

namespace WebMVC.Services
{
    public class CategoryService : ICategoryService
    {
        protected readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<CategoryItemIndexVM>> GetCategoryIndexAsync(string? searchString)
        {
            var context = _context.Category.AsQueryable();
            if(searchString != null)
            {
                context = context.Where(_ => _.Name.Contains(searchString.ToLower()));
            }
            var catigories = await context.Select(_ => new CategoryItemIndexVM()
            {
                Id = _.Id,
                Name = _.Name,
                Description = _.Description,
                CreatedOn = DateTime.Now,
                CreatedBy = _.CreatedBy,
            }).ToListAsync();

            return catigories;
        }
    }
}
