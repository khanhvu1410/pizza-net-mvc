using PizzaNet.Domain.Enums;

namespace PizzaNet.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }    
        public Guid CustomerId { get; set; }
        public Guid? ApproverId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public User Customer { get; set; } = default!;
        public User? Approver { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = default!;
    }
}
