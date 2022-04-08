using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.CustomValidation;

namespace WebMVC.ViewModels.Books.Requests;

public class BookAddVm : IValidatableObject
{
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

    [ImageUrlValidation]
    [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Image File")] public IFormFile? ImageFile { get; set; }


    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if ((ImageFile != null) & !string.IsNullOrEmpty(ImageUrl))
            yield return new ValidationResult("Require only Image File or Image Url");

        if ((ImageFile == null) & string.IsNullOrEmpty(ImageUrl))
            yield return new ValidationResult("Require only Image File or Image Url");
    }
}