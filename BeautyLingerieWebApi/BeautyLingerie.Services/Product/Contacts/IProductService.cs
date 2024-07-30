namespace BeautyLingerie.Services.Product.Contacts
{
    using BeautyLingerie.ViewModels.Product;
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
    }
}
