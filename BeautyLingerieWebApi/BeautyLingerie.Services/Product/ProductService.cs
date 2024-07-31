namespace BeautyLingerie.Services.Product
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Media.Contracts;
    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
    using Microsoft.EntityFrameworkCore;

    public class ProductService:IProductService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        private IS3Service mediaService;

        public ProductService(BeautyLingerieDbContext dbContext, IS3Service mediaService)
        {
            this.dbContext = dbContext;
            this.mediaService = mediaService;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            
            List<ProductViewModel> products = await dbContext.Products.Select(p =>  new ProductViewModel 
            {
                Id= p.ProductId,
                Name = p.Name,
                ImageUrl = //await mediaService.GetFileUrlByKeyAsync("" , p.ImageKey),
                Price = p.Price,
            }
            ).AsNoTracking()
            .ToListAsync();
            return products;
        }
    }
}
