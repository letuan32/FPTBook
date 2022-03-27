#nullable disable

using Domain.Base;

namespace Domain.Entities
{
    public partial class Book : BaseEntity<int>
    {
        public Book()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}