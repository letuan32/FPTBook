using System.ComponentModel.DataAnnotations;
using System.Net;
using WebMVC.Helpers;

namespace WebMVC.CustomValidation;

public class ImageUrlValidation : ValidationAttribute
{
    
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value==null) return ValidationResult.Success;
            
        var isResponse = HttpClientHelper.IsResponse(value.ToString());

        if (isResponse)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult
                ("Url not valid.");
        } //If exception thrown then couldn't get response from address
       
    }
}