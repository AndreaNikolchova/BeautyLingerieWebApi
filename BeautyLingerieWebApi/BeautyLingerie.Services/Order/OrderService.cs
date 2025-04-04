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
                var productSize = await dbContext.ProductSize
                    .Include(ps => ps.Product)
                    .FirstOrDefaultAsync(ps =>
                        ps.ProductId == productModel.ProductId &&
                        ps.SizeId == productModel.SizeId);

                if (productSize != null && productSize.Quantity >= productModel.Quantity)
                {
                    productSize.Quantity -= productModel.Quantity;

                    orderProducts.Add(new OrderProduct
                    {
                        ProductId = productSize.ProductId,
                        SizeId = productSize.SizeId,
                        OrderId = order.OrderId,
                        Order = order,
                        Quantity = productModel.Quantity,
                        PriceAtOrderTime = productSize.Product.Price
                    });
                }
                else
                {
                  
                    throw new InvalidOperationException("Недостатъчна наличност или липсващ размер.");
                }
            }

            await dbContext.Orders.AddAsync(order);
            await dbContext.OrderProducts.AddRangeAsync(orderProducts);
            await dbContext.SaveChangesAsync();
        }


    }
}
