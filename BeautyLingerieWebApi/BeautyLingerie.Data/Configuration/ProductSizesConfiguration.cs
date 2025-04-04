using BeautyLingerie.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeautyLingerie.Data.Configuration
{
    public  class ProductSizesConfiguration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasData(Seed());
        }

        private ProductSize[] Seed()
        {
            ICollection<ProductSize> productSizes = new HashSet<ProductSize>()
            {
                new ProductSize
                {
                    ProductId = Guid.Parse("09595ab6-c4af-4223-812c-6d74f2767997"),
                    SizeId = Guid.Parse("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"),
                    Quantity = 3
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("09595ab6-c4af-4223-812c-6d74f2767997"),
                    SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                    Quantity = 5
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("09595ab6-c4af-4223-812c-6d74f2767997"),
                    SizeId = Guid.Parse("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"),
                    Quantity = 4
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                    SizeId = Guid.Parse("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"),
                    Quantity = 3
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                    SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                    Quantity = 5
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("e9c8d216-5c64-4f78-8487-41dc0a29c77e"),
                    SizeId = Guid.Parse("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"),
                    Quantity = 4
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                    SizeId = Guid.Parse("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"),
                    Quantity = 10
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                    SizeId = Guid.Parse("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"),
                    Quantity = 6
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                    SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                    Quantity = 7
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                    SizeId = Guid.Parse("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"),
                    Quantity = 8
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("2352a676-800c-4e14-8ee7-1ca1fd32280c"),
                    SizeId = Guid.Parse("ae2b67e1-df68-4e2d-9c3a-8b6e1e8b9f3c"),
                    Quantity = 5
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                    SizeId = Guid.Parse("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"),
                    Quantity = 7
                },
                new ProductSize
                {
                    ProductId = Guid.Parse("a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"),
                    SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"),
                    Quantity = 4
                }
            };
            return productSizes.ToArray();
        }
    }
}
