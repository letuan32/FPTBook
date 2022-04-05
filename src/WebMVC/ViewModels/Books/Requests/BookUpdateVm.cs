using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebMVC.Models.Books.Requests;

public class BookUpdateVm
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    [Display(Name="Name")]
    public string Name { get; set; } = null!;
    
   
    [StringLength(1000)]
    [Display(Name="Description")]
    public string? Description { get; set; }

    [Required]
    public int Price { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    [Display(Name="Image Link")]
    public string? ImageUrl { get; set; }
    public IFormFile? ImageFile { get; set; }
    
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    public IEnumerable<SelectListItem>? Categories { get; set; }
}