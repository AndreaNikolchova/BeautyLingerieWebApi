using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeautyLingerie.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "f1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e",
                    RoleId = "a1b2c3d4-e5f6-4a1b-9e2e-8d5c2d5f0a7e"
                }
            );
        }
    }
}
