using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.CustomValidation;

namespace WebMVC.Models.Books.Requests;

public class BookUpdateVm
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;


    [MaxLength(1000)]
    [DataType(DataType.MultilineText)]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Required] public int Price { get; set; }

    [Required] public int Quantity { get; set; }


    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    
    public IEnumerable<SelectListItem>? Categories { get; set; }
    
    
    public string ImageUrl { get; set; } = null!;
}