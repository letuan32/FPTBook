using WebMVC.ViewModels.Categories.Responses;

namespace WebMVC.Services.Base
{
    public interface ICategoryService
    {
        public Task<List<CategoryItemIndexVM>> GetCategoryIndexAsync(string? searchString);
    }
}
