using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BeautyLingerie.Data.Models;

namespace BeautyLingerie.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(Seed());
        }

        private Product[] Seed()
        {
            ICollection<Product> products = new HashSet<Product>()
            {
             new Product()
             {
                ProductId = Guid.Parse("09595ab6-c4af-4223-812c-6d74f2767997"),
                Name = "Tropical Breeze Bikini",
                Description = "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.",
                Price = 26.00m,
                ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/zaplviqvawybdtxwgoto.jpg",
                CategoryId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                CreatedOn = DateTime.UtcNow,
               ColorId = Guid.Parse("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"),
            },
            new Product()
            {
                ProductId = Guid.Parse("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                Name = "Beautiful Pink Lace Underwear",
                Description = "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.",
                Price = 3.50m,
                ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/jvvbilveebrqwey5vnn9.jpg",
                CategoryId = Guid.Parse("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                CreatedOn = DateTime.UtcNow,
                ColorId = Guid.Parse("48f0be7d-e69d-4933-b81c-0ff4b7106d5d")

            },
             new Product()
            {
                ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                Name = "Elegant White Lace Bra",
                Description = "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.",
                Price = 12.99m,
                ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/w0hvcjfrp7tcbucmszu1.jpg",
                CategoryId = Guid.Parse("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                CreatedOn = DateTime.UtcNow,
                ColorId = Guid.Parse("37bc840f-355e-4bb2-8b79-ccca593ee1c6")

            },
            new Product()
            {
                ProductId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                Name = "Chic Black Lace Tank Top",
                Description = "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.",
                Price = 29.99m,
                ImageUrl = "https://res.cloudinary.com/dqko9lpej/image/upload/v1742805902/rbku1kdduiuluc8jq6qy.jpg",
                CategoryId = Guid.Parse("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"),
                CreatedOn = DateTime.UtcNow,
                ColorId = Guid.Parse("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6")
            },
            };

            return products.ToArray();
        }


    }
}


