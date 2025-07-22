using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.Password)
                .IsRequired();

            builder.Property(u => u.FullName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(u => u.Address)
                .HasMaxLength(200);

            builder.Property(u => u.Role)
                .IsRequired();
        }
    }
}
