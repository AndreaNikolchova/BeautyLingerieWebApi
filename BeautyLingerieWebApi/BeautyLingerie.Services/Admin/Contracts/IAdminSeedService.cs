using Microsoft.AspNetCore.Identity;


namespace BeautyLingerie.Services.Admin.Contracts
{
    public interface IAdminSeedService
    {
        IdentityUser CreateAdminUser();
    }
}
