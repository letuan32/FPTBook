#nullable disable

using Domain.Base;
using Domain.Enums;

namespace Domain.Entities

{
    public class Order : BaseEntity<int>
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderState State { get; set; }
        public int Total { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}