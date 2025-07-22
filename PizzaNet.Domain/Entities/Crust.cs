namespace PizzaNet.Domain.Entities
{
    public class Crust
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<ProductDetails> ProductDetails { get; set; } = default!;
    }
}
