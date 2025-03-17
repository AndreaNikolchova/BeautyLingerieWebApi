using BeautyLingerie.Services.Admin.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;


namespace BeautyLingerie.Services.Admin
{
    public class AdminSeedService : IAdminSeedService
    {
        private readonly IConfiguration _configuration;

        public AdminSeedService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IdentityUser CreateAdminUser()
        {
            var adminEmail = _configuration["Admin:Email"];
            var adminPassword = _configuration["Admin:Password"];

            var admin = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = adminEmail,
                NormalizedUserName = adminEmail.ToUpper(),
                Email = adminEmail,
                NormalizedEmail = adminEmail.ToUpper(),
                EmailConfirmed = true
            };

            var passwordHasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, adminPassword);

            return admin;
        }

    }
}
