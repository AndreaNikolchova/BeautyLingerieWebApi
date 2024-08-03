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
                ImageUrl = p.ImageKey,
                Price = p.Price,
            }
            ).AsNoTracking()
            .ToListAsync();
            foreach( var item in products )
            {
                item.ImageUrl = await mediaService.GetFileUrlByKeyAsync("beauty-lingerie-bucket", item.ImageUrl);
            }
            return products;
        }
        public async Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId)
        {
            var product = await dbContext.Products.Where(p => p.ProductId == productId).Select(p => new ProductDetailsViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageKey,
                Price = p.Price,
                ColorName = p.Color.Name,
                CatgeryName = p.Category.Name,
                Size = p.Size.Name
            }).FirstOrDefaultAsync();
            if( product == null )
            {
                throw new ArgumentException("No product found with this id");
            }
                product.ImageUrl = await mediaService.GetFileUrlByKeyAsync("beauty-lingerie-bucket", product.ImageUrl);
                return product;

        }
        public async Task<ProductDetailsViewModel> GetProductByNameAsync(string name)
        {
            var product = await dbContext.Products.Where(p => p.Name == name).Select(p => new ProductDetailsViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageKey,
                Price = p.Price,
                ColorName = p.Color.Name,
                CatgeryName = p.Category.Name,
                Size = p.Size.Name
            }).FirstOrDefaultAsync();
            if (product == null)
            {
                throw new ArgumentException("No product found with this name");
            }
            product.ImageUrl = await mediaService.GetFileUrlByKeyAsync("beauty-lingerie-bucket", product.ImageUrl);
            return product;

        }
        public async Task<IEnumerable<ProductViewModel>> GetProductsByCategoryNameAsync(string categoryName)
        {

            List<ProductViewModel> products = await dbContext.Products.Where(p=> p.Category.Name == categoryName).Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                ImageUrl = p.ImageKey,
                Price = p.Price,
            }
            ).AsNoTracking()
            .ToListAsync();
            foreach (var item in products)
            {
                item.ImageUrl = await mediaService.GetFileUrlByKeyAsync("beauty-lingerie-bucket", item.ImageUrl);
            }
            return products;
        }

    }
}
