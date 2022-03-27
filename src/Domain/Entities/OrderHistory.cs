#nullable disable

using Domain.Base;

namespace Domain.Entities
{
    public partial class OrderHistory : BaseEntity<int>
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
    }
}