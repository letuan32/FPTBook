using Microsoft.AspNetCore.Mvc;
using WebMVC.Services;
using WebMVC.Services.Base;
using WebMVC.ViewModels.Categories.Responses;

namespace WebMVC.Areas.StoreOwner.Controllers
{
    [Area("StoreOwner")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? searchString)
         {
            var catigories = await _categoryService.GetCategoryIndexAsync(searchString);

            var vm = new CategoryIndexVm()
            {
                Categories = catigories,
            };

            return View(vm);
        }
    }
}
