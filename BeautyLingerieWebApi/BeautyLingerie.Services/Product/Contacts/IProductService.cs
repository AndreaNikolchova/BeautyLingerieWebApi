namespace BeautyLingerie.Services.Product.Contacts
{
    using BeautyLingerie.ViewModels.Product;
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId);
        Task<ProductDetailsViewModel> GetProductByNameAsync(string name);
    }
}
