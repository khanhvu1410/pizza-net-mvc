using PizzaNet.Domain.Enums;

namespace PizzaNet.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string? Address { get; set; }
        public DateTime CreatedAt {  get; set; }
        public UserRole Role { get; set; }
        public ICollection<Order> Orders { get; set; } = default!;
    }
}
