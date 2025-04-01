namespace BeautyLingerie.Services.Order
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Order.Contracts;
    using BeautyLingerie.ViewModels.Order;
    using BeautyLingerie.Data.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        public BeautyLingerieDbContext dbContext { get; set; }

        public OrderService(BeautyLingerieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddGuestOrder(AddOrderGuestViewModel model)
        {
            
            var order = new Order
            {
                TotalSum = model.TotalSum,
                CreatedOn = model.CreatedOn,
                FullName = model.FullName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                ShippingAddress = model.ShippingAddress,
                Status = "Pending",
               
                Products = model.Products.Select(p => dbContext.Products
                    .FirstOrDefault(x => x.ProductId == p.Id))
                    .Where(product => product != null)
                    .ToList()
            };

            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
        }
    }
}
