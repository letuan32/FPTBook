using System.ComponentModel.DataAnnotations;

namespace Domain.Enums;

public enum OrderState
{
    [Display(Name = "Ordering")]
    Ordering,
    
    [Display(Name = "Success")]
    Success,
    
    [Display(Name="Cancel")]
    Cancel
}