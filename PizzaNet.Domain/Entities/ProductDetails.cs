namespace PizzaNet.Domain.Entities
{
    public class ProductDetails
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SizeId { get; set; }
        public Guid CrustId { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; } = default!;
        public Size Size { get; set; } = default!;
        public Crust Crust { get; set; } = default!;
        public ICollection<OrderDetails> OrderDetails { get; set; } = default!;
    }
}
