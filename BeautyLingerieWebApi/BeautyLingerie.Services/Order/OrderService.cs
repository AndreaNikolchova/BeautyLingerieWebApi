using BeautyLingerie.Data;
using BeautyLingerie.Services.Order.Contracts;
using BeautyLingerie.ViewModels.Order;
using BeautyLingerie.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

namespace BeautyLingerie.Services.Order
{
    public class OrderService : IOrderService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        public async Task<IEnumerable<OrderViewModel>> GetAllAsync()
        {
            try
            {
                List<OrderViewModel> orders = await dbContext.Orders.Select(o => new OrderViewModel
                {
                    Id = o.OrderId,
                    CreatedOn = o.CreatedOn,
                    TotalSum = o.TotalSum,
                    Products = o.Products.Select(p => new ProductViewModel
                    {
                        Id = p.ProductId,
                        Name = p.Name,
                        ImageUrl = p.ImageKey,
                        Price = p.Price


                    }).ToList(),

                })
                .AsNoTracking()
                .ToListAsync();

            return orders;
            }
            catch
            {
                return null;
            }
        }

        public async Task<OrderViewModel> GetOrderByIdAsync(Guid id)
        {
            return await dbContext.Orders.Where(o => o.OrderId == id).Select(o => new OrderViewModel
            {
                Id = o.OrderId,
                CreatedOn = o.CreatedOn,
                TotalSum = o.TotalSum,

            }).FirstOrDefaultAsync();
        }
    }
}
