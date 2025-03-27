namespace BeautyLingerie.Services.Product
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Data.Models;
    using BeautyLingerie.Services.MediaService.Contracts;
    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
    using Microsoft.EntityFrameworkCore;
   
    public class ProductService : IProductService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        private IMediaService mediaService;

        public ProductService(BeautyLingerieDbContext dbContext, IMediaService mediaService)
        {
            this.dbContext = dbContext;
            this.mediaService = mediaService;
        }
        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {

            List<ProductViewModel> products = await dbContext.Products.Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                Quantity = p.Quantity
            }
            ).AsNoTracking()
            .ToListAsync();
            
            return products;

        }
        public async Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId)
        {
            try
            {
                var product = await dbContext.Products.Where(p => p.ProductId == productId).Select(p => new ProductDetailsViewModel
                {
                    Id = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    ColorName = p.Color.Name,
                    CatgeryName = p.Category.Name,
                    Size = p.Size.Name
                }).FirstOrDefaultAsync();

              
                return product;

            }
            catch
            {
                return null;
            }

        }
        public async Task<ProductDetailsViewModel> GetProductByNameAsync(string name)
        {
            try
            {

            var product = await dbContext.Products.Where(p => p.Name == name).Select(p => new ProductDetailsViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                ColorName = p.Color.Name,
                CatgeryName = p.Category.Name,
                Size = p.Size.Name
            }).FirstOrDefaultAsync();
           
          
            return product;
            }
            catch
            {
                return null;
            }

        }
        public async Task<IEnumerable<ProductViewModel>> GetProductsByCategoryNameAsync(string categoryName)
        {

            List<ProductViewModel> products = await dbContext.Products.Where(p => p.Category.Name == categoryName).Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
            }
            ).AsNoTracking()
            .ToListAsync();
           
            return products;
        }
        public async Task<IEnumerable<ProductViewModel>> GetNewestProducts()
        {

            List<ProductViewModel> products = await dbContext.Products.OrderByDescending(p => p.CreatedOn).Select(p => new ProductViewModel
            {
                Id = p.ProductId,
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
            }
            ).AsNoTracking()
            .ToListAsync();
           
            return products;
        }

        public async Task AddProductAsync(AddProductViewModel model)
        {
            var category = await this.dbContext.Categories.Where(c => c.Name == model.Category).FirstOrDefaultAsync();
            if(category == null)
            {
                category = new Category()
                {
                    Name = model.Category
                };
              
            }
            var size = await this.dbContext.Sizes.Where(s=>s.Name == model.Size).FirstOrDefaultAsync();
            if(size == null)
            {
                size = new Size()
                {
                    Name = model.Size
                };
            }
           
            var picture = await this.mediaService.UploadPictureAsync(model.Photo, model.Name);
            Product product = new Product()
            {
                Name = model.Name,
                ImageUrl = picture,
                Description = model.Description,
                Size = size,
                Quantity = model.Quantity,
                Price = model.Price,
            
            };
           
            await dbContext.Products.AddAsync(product);
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
           
        }
    }
}
