using BeautyLingerieWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BeautyLingerieWebApi.Data
{
    public class BeautyLingerieDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<WishList> WishList { get; set; }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public BeautyLingerieDbContext(DbContextOptions<BeautyLingerieDbContext> options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder builder)        {

            builder.Entity<CartProduct>().HasOne(x => x.Cart)
                .WithMany(x => x.CartProduct)
                .HasForeignKey(x => x.Id);

            builder.Entity<OrderProduct>().HasOne(x => x.Order)
                .WithMany(x => x.OrderProducts)
                .HasForeignKey(x => x.Id);


        }


    }
}
