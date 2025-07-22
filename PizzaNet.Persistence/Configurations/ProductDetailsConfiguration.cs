using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Persistence.Configurations
{
    public class ProductDetailsConfiguration : IEntityTypeConfiguration<ProductDetails>
    {
        public void Configure(EntityTypeBuilder<ProductDetails> builder)
        {
            builder.Property(pd => pd.Price)
                .IsRequired();

            builder.HasOne(pd => pd.Product)
                .WithMany(p => p.ProductDetails)
                .HasForeignKey(pd => pd.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pd => pd.Size)
                .WithMany(s => s.ProductDetails)
                .HasForeignKey(pd => pd.SizeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pd => pd.Crust)
                .WithMany(c => c.ProductDetails)
                .HasForeignKey(pd => pd.CrustId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
