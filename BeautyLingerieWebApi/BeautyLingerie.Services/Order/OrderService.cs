namespace BeautyLingerie.Services.Order
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Order.Contracts;
    using BeautyLingerie.ViewModels.Order;
    using BeautyLingerie.Data.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using BeautyLingerie.ViewModels.Product;

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
                        ps.SizeId == this.dbContext.Sizes.First(x=>x.Name == productModel.SelectedSize).SizeId);

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
                  
                    throw new InvalidOperationException();
                }
            }

            await dbContext.Orders.AddAsync(order);
            await dbContext.OrderProducts.AddRangeAsync(orderProducts);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderViewModel>> GetOrders(string email)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return Enumerable.Empty<OrderViewModel>();
            }


            return await dbContext.Orders
                .Where(o => o.Email == user.Email)
                .Include(o => o.OrderProducts)
                    .ThenInclude(op => op.Product)
                .Select(o => new OrderViewModel
                {
                    Id = o.OrderId,
                    TotalSum = o.TotalSum,
                    CreatedOn = o.CreatedOn,
                    Products = o.OrderProducts.Select(op => new ProductViewModel
                    {
                        Id = op.ProductId,
                        Name = op.Product.Name,
                        Price = op.PriceAtOrderTime,
                        Quantity = op.Quantity,
                        ImageUrl = op.Product.ImageUrl,
                    }).ToList(),
                    Status = o.Status
                    
                }).ToListAsync();
        }

        public async Task<OrderViewModel?> GetOrderById(Guid orderId)
        {
            var order = await dbContext.Orders.Where(o=>o.OrderId==orderId)
                .Include(o => o.OrderProducts)
                      .ThenInclude(op => op.Product)
                  .Select(o => new OrderViewModel
                  {
                      Id = o.OrderId,
                      TotalSum = o.TotalSum,
                      CreatedOn = o.CreatedOn,
                      Products = o.OrderProducts.Select(op => new ProductViewModel
                      {
                          Id = op.ProductId,
                          Name = op.Product.Name,
                          Price = op.PriceAtOrderTime,
                          Quantity = op.Quantity,
                          ImageUrl = op.Product.ImageUrl,
                      }).ToList(),
                      Status = o.Status,
                      ShippingAddress = o.ShippingAddress,
                      FullName = o.FullName,
                      PhoneNumber = o.PhoneNumber

                  })
                  .FirstOrDefaultAsync();

            return order;
        }
    }
}
