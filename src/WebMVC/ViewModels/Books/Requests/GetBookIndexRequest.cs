namespace WebMVC.ViewModels.Books.Requests;

public class GetBookIndexRequest
{
    public string? SortOrder { get; set; }
    public string? CurrentSearch { get; set; }
    public string? SearchString { get; set; }
    
    public int? FilterOption { get; set; }
    public int? Page { get; set; }
    
    
}