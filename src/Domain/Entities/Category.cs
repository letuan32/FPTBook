#nullable disable

using Domain.Base;

namespace Domain.Entities

{
    public partial class Category : BaseEntity<int>
    {
        public Category()
        {
            Book = new HashSet<Book>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}