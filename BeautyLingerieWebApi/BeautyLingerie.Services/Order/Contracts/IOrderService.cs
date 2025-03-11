using BeautyLingerie.ViewModels.Product;

namespace BeautyLingerie.Services.Order.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetAllAsync();
        Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId);
        Task<ProductDetailsViewModel> GetProductByNameAsync(string name);
        Task<IEnumerable<ProductViewModel>> GetProductsByCategoryNameAsync(string categoryName);
        Task<IEnumerable<ProductViewModel>> GetNewestProducts();
    }
}
