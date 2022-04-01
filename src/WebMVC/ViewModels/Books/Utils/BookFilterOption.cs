using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebMVC.Models.Books.Utils;

public class BookFilterOption
{
    public List<SelectListItem> CategoriesFilter { get; set; }
}