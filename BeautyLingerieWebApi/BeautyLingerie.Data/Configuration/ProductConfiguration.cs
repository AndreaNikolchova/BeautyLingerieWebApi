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
                Name = "Tropical Breeze Bikini",
                Description = "Dive into paradise with our Tropical Breeze Bikini, featuring a vibrant blend of blue and pink with a chic palm tree pattern. The set includes a flattering bikini and a matching pink pareo, perfect for effortless beach style and comfort. Ideal for sun-soaked getaways and poolside lounging.",
                Price = 26.00m,
                Quantity = 3,
                ImageUrl = "bikiniSeed.jpg",
                CategoryId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
               SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                ColorId = Guid.Parse("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"),
                CreatedOn = DateTime.UtcNow,

            },
             new Product()
            {
                Name = "Beautiful Pink Lace Underwear",
                Description = "Experience elegance and comfort with our Beautiful Pink Lace Underwear. This stunning piece features delicate lace detailing and a lovely pink hue, making it a perfect choice for those who appreciate beauty and style. Ideal for everyday wear or special occasions.",
                Price = 3.50m,
                Quantity = 5,
                ImageUrl = "underwearSeed.jpg",
                CategoryId = Guid.Parse("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                SizeId = Guid.Parse("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"),
                ColorId =  Guid.Parse("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"),
                CreatedOn = DateTime.UtcNow,
            },
            new Product()
            {
                Name = "Elegant White Lace Bra",
                Description = "Embrace sophistication and comfort with our Elegant White Lace Bra. This exquisite piece features intricate lace detailing and a pristine white color, making it an ideal choice for those who appreciate elegance and quality. Perfect for both everyday wear and special occasions.",
                Price = 12.99m,
                Quantity = 7,
                ImageUrl = "braSeed.jpg",
                CategoryId = Guid.Parse("f6e5d4c3-b2a1-4d5e-98c3-769b9b48adf7"),
                SizeId = Guid.Parse("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"),
                ColorId = Guid.Parse("37bc840f-355e-4bb2-8b79-ccca593ee1c6"),
                CreatedOn = DateTime.UtcNow,
            },
             new Product()
            {
                Name = "Chic Black Lace Tank Top",
                Description = "Elevate your wardrobe with our Chic Black Lace Tank Top. This versatile piece features elegant lace detailing and a sleek black design, perfect for adding a touch of sophistication to any outfit. Ideal for casual outings or dressed-up events.",
                Price = 29.99m,
                Quantity = 7,
                ImageUrl = "othersSeed.jpg",
                CategoryId = Guid.Parse("9e8b7c6d-5a4b-3c2d-1e0f-a9b8c7d6e5f4"),
                SizeId = Guid.Parse("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"),
                ColorId =Guid.Parse("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"),
                CreatedOn = DateTime.UtcNow,
            },
            };
            return products.ToArray();

        }
    }
}
