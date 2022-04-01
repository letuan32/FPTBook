namespace WebMVC.Models.Books.Responses;

public class BookIndexVm
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string ImageUrl { get; set; }
    public int TotalSales { get; set; } 
}