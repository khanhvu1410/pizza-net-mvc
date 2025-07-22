using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Persistence.Configurations
{
    internal class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(od => new { od.ProductDetailsId, od.OrderId });

            builder.Property(od => od.Quantity)
                .IsRequired();

            builder.HasOne(od => od.ProductDetails)
                .WithMany(pd => pd.OrderDetails)
                .HasForeignKey(od => od.ProductDetailsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
