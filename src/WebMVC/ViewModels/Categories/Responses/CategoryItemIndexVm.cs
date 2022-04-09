namespace WebMVC.ViewModels.Categories.Responses
{
    public class CategoryItemIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string? Description { get; set; }
    }
}
