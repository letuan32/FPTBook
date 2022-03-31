#nullable disable

using Domain.Base;

namespace Domain.Entities

{
    public partial class Order : BaseEntity<int>
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public byte State { get; set; }
        public int Total { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}