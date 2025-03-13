using BeautyLingerie.ViewModels.Order;

namespace BeautyLingerie.Services.Order.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetAllAsync();
        Task<OrderViewModel> GetOrderByIdAsync(Guid id);
      
    }
}
