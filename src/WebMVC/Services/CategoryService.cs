using Infrastructure.Database;
using WebMVC.Services.Base;

namespace WebMVC.Services
{
    public class CategoryService : IServiceBase
    {
        protected readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
