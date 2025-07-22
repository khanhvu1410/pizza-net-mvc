using Microsoft.EntityFrameworkCore;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Persistence.DataSeeders
{
    internal static class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("ad0126a6-c505-46cf-bcfd-413dda3be3a8"), Name = "Pizza" },
                new Category { Id = Guid.Parse("00b44074-3071-4389-b3ff-7871e100916e"), Name = "Chicken" },
                new Category { Id = Guid.Parse("00ee412d-d067-423b-b546-3016d85d2e97"), Name = "Spagetti" },
                new Category { Id = Guid.Parse("2ba5cbba-b37a-459d-a8b9-d43a4477bcd1"), Name = "Appetizer" },
                new Category { Id = Guid.Parse("a05753b7-3817-4ed4-b762-4232b2f1209d"), Name = "Dessert" },
                new Category { Id = Guid.Parse("24cbde45-e340-42d0-82fd-f376cb15ec2b"), Name = "Drinks" });
        }
    }
}