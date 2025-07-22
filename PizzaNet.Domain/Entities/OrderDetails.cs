namespace PizzaNet.Domain.Entities
{
    public class OrderDetails
    {
        public Guid ProductDetailsId { get; set; }
        public Guid OrderId { get; set; }   
        public int Quantity { get; set; }
        public ProductDetails ProductDetails { get; set; } = default!;
        public Order Order { get; set; } = default!;
    }
}
