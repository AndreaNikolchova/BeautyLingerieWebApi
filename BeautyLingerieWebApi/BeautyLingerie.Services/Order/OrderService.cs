namespace BeautyLingerie.Services.Order
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Order.Contracts;
    using BeautyLingerie.ViewModels.Order;
    using BeautyLingerie.Data.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

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
            };

            var orderProducts = new List<OrderProduct>();

            foreach (var productModel in model.Products)
            {
                var product = await dbContext.Products
                    .FirstOrDefaultAsync(p => p.ProductId == productModel.Id);

                if (product != null)
                {
                    product.Quantity -= productModel.Quantity;
                    orderProducts.Add(new OrderProduct
                    {
                        ProductId = product.ProductId,
                        OrderId = order.OrderId,
                        Quantity = productModel.Quantity,
                        PriceAtOrderTime = product.Price
                    });
                }
            }

            await dbContext.Orders.AddAsync(order);
            await dbContext.OrderProducts.AddRangeAsync(orderProducts);
            await dbContext.SaveChangesAsync();
        }

    }
}
