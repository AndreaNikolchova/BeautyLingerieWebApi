using BeautyLingerie.ViewModels.Order;
using BeautyLingerie.ViewModels.Product;

namespace BeautyLingerie.Services.Order.Contracts
{
    public interface IOrderService
    {
        Task AddGuestOrder(AddOrderGuestViewModel model);
        Task<IEnumerable<OrderViewModel>> GetOrders(string email);

    }
}
