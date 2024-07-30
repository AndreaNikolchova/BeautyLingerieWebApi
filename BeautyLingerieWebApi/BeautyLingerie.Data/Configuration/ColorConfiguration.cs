using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BeautyLingerie.Data.Models;

namespace BeautyLingerieWeb.Data.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {

        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(Seed());
        }

        private Color[] Seed()
        {
            ICollection<Color> colors = new HashSet<Color>()
                {
                     new Color { ColorId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"), Name = "Red" },
    new Color { ColorId = Guid.Parse("21ec2020-3aea-4069-a2dd-08002b30309d"), Name = "Blue" },
    new Color { ColorId = Guid.Parse("ed6958ab-267e-4148-97f2-e1d9d4fcd8b7"), Name = "Yellow" },
    new Color { ColorId = Guid.Parse("68e3f5e2-6f52-4095-85c6-70bfb0d80b29"), Name = "Green" },
    new Color { ColorId = Guid.Parse("81e5c1be-6c10-44e7-89ed-8c7dd6b3d1a6"), Name = "Black" },
    new Color { ColorId = Guid.Parse("37bc840f-355e-4bb2-8b79-ccca593ee1c6"), Name = "White" },
    new Color { ColorId = Guid.Parse("a2d6b5cb-2a3e-4d58-a7fc-e42a67c4ff7d"), Name = "Orange" },
    new Color { ColorId = Guid.Parse("b6eb6d37-6d69-4b82-a5ec-9cf9a2e547a1"), Name = "Purple" },
    new Color { ColorId = Guid.Parse("48f0be7d-e69d-4933-b81c-0ff4b7106d5d"), Name = "Pink" },
    new Color { ColorId = Guid.Parse("5531e2b6-0f72-40f8-9d62-6e7fc621c3f4"), Name = "Brown" },
    new Color { ColorId = Guid.Parse("a3a0a98e-7e51-4c32-9c2b-b00d9057ed9a"), Name = "Gray" },
    new Color { ColorId = Guid.Parse("b5b14f99-b75d-4017-bdd2-2fc08c30f35a"), Name = "Cyan" },
    new Color { ColorId = Guid.Parse("c1c34f64-c8e3-4d43-b8f2-d9ad4c2fbc2a"), Name = "Magenta" },
    new Color { ColorId = Guid.Parse("d7d6aeba-45b8-49c5-bf80-1d12c967ce5d"), Name = "Lime" },
    new Color { ColorId = Guid.Parse("e6e7a663-32b3-4c8f-a1da-051ac8e5dca9"), Name = "Teal" },
    new Color { ColorId = Guid.Parse("f3f4a0a4-12cb-4f5f-b3a8-3c8c8ea5dc1c"), Name = "Indigo" },
    new Color { ColorId = Guid.Parse("111a1245-7c45-4a12-baf4-cbdb5e85f7e6"), Name = "Turquoise" },
    new Color { ColorId = Guid.Parse("3f3b5865-bd1e-4a21-9473-7a77d601b0f5"), Name = "Multicolor" }
                };
            return colors.ToArray();

        }
    }
}

