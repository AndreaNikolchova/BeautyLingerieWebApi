namespace BeautyLingerie.Services.Product.Contacts
{
    using BeautyLingerie.ViewModels.Product;
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId);
        Task<ProductDetailsViewModel> GetProductByNameAsync(string name);
        Task<IEnumerable<ProductViewModel>> GetProductsByCategoryNameAsync(string categoryName);
        Task<IEnumerable<ProductViewModel>> GetNewestProducts();
        Task AddToCartAsync(Guid productId, string userId);
        Task<IEnumerable<ProductDetailsViewModel>> GetProductsInCartAsync(string userId);
    }
}
