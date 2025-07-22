namespace PizzaNet.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }    
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsPizza { get; set; }
        public string? ImageUrl { get; set; }
        public Category Category { get; set; } = default!;
        public ICollection<ProductDetails> ProductDetails { get; set; } = default!;
    }
}
