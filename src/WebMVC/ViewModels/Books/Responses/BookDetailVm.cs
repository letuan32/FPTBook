using System.ComponentModel;

namespace WebMVC.ViewModels.Books.Responses;

public class BookDetailVm
{
    [ReadOnly(true)] public int Id { get; set; }
    [ReadOnly(true)] public string Name { get; set; } = null!;

    [ReadOnly(true)] public string Description { get; set; } = null!;

    [ReadOnly(true)] public string Category { get; set; } = null!;
    [ReadOnly(true)] public int CategoryId { get; set; }

    [ReadOnly(true)] public int Price { get; set; }

    [ReadOnly(true)] public int Quantity { get; set; }

    [ReadOnly(true)] public string ImageUrl { get; set; } = null!;

    [ReadOnly(true)] public int TotalSales { get; set; }

    [ReadOnly(true)] public DateTime CreatedDate { get; set; }
}