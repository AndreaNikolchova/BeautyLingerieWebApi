using BeautyLingerieWebApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BeautyLingerieWebApi.Data.Configuration
{
    public class SizesConfiguration : IEntityTypeConfiguration<Size>
    {

        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(Seed());
        }

        private Size[] Seed()
        {
            ICollection<Size> sizes = new HashSet<Size>()
            {
                new Size { SizeId = Guid.Parse("d1b82e13-25c1-4d5e-98c3-769b9b48adf7"), Name = "S" },
    new Size { SizeId = Guid.Parse("be1e8a73-6b95-4e2e-9673-d4c5a4e8b0da"), Name = "M" },
    new Size { SizeId = Guid.Parse("e2a05d49-c2c4-4ad2-9ae3-f3d1c6a07cb2"), Name = "L" },
    new Size { SizeId = Guid.Parse("c38c1b69-b3b4-4a1b-9e2e-8d5c2d5f0a7e"), Name = "XL" },
    new Size { SizeId = Guid.Parse("ae2b67e1-df68-4e2d-9c3a-8b6e1e8b9f3c"), Name = "XXL" }
            };
            return sizes.ToArray();

        }
    }
}

