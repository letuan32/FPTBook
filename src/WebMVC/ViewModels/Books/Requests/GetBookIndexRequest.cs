namespace WebMVC.ViewModels.Books.Requests;

public class GetBookIndexRequest
{
    public string SortOption { get; set; }
    public string CurrentSearch { get; set; }
    public string SearchString { get; set; }

    public int? FilterOption { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
    
    public int? CreatedBy { get; set; }
}