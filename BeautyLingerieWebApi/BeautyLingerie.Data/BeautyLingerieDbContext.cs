using BeautyLingerie.Data.Configuration;
using BeautyLingerie.Data.Models;
using BeautyLingerie.Services.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BeautyLingerie.Data
{
    public class BeautyLingerieDbContext : IdentityDbContext<IdentityUser>
    {
        private readonly IAdminSeedService adminSeedService;

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WishList> WishList { get; set; }
        public BeautyLingerieDbContext(DbContextOptions<BeautyLingerieDbContext> options) : base(options)
        {
           // _adminSeedService = adminSeedService;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //var admin = _adminSeedService.CreateAdminUser();
           // modelBuilder.Entity<IdentityUser>().HasData(admin);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new SizesConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

        }
    }
}
