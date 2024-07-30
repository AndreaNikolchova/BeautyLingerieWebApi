using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BeautyLingerieWebApi.Models;

namespace BeautyLingerieWebApi.Data.Configuration
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(Seed());
        }

        private Category[] Seed()
        {
            ICollection<Category> categories = new HashSet<Category>()
            {
                 new Category { CategoryId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"), Name = "Bikini" },
                 new Category { CategoryId = Guid.Parse("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"), Name = "Underwear" },
                 new Category { CategoryId = Guid.Parse("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"), Name = "Others" }

            };
            return categories.ToArray();

        }
    }
}

