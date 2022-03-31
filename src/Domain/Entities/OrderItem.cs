#nullable disable

using Domain.Base;

namespace Domain.Entities
{
    public partial class OrderItem : BaseEntity<int>
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}