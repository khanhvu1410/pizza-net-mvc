using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Persistence.Configurations
{
    internal class CrustConfiguration : IEntityTypeConfiguration<Crust>
    {
        public void Configure(EntityTypeBuilder<Crust> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
