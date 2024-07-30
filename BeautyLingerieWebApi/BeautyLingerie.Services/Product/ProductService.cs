namespace BeautyLingerie.Services.Product
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Media.Contracts;
    using BeautyLingerie.ViewModels.Product;

    public class ProductService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        private IS3Service mediaService;

        public ProductService(BeautyLingerieDbContext dbContext, IS3Service mediaService)
        {
            this.dbContext = dbContext;
            this.mediaService = mediaService;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllAsync(){ throw new NotImplementedException(); }
    }
}
