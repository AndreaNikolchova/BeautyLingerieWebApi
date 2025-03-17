using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BeautyLingerie.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e", // Ръчно зададен GUID
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
