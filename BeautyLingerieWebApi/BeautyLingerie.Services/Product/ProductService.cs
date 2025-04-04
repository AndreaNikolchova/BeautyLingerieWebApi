namespace BeautyLingerie.Services.Product
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Data.Models;
    using BeautyLingerie.Services.MediaService.Contracts;
    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
    using BeautyLingerie.ViewModels.Size;
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
            var products = await dbContext.Products
                .Where(p => p.ProductSizes.Sum(ps => ps.Quantity) > 0) 
                .Select(p => new ProductViewModel
                {
                    Id = p.ProductId,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Quantity = p.ProductSizes.Sum(ps => ps.Quantity)
                })
                .AsNoTracking()
                .ToListAsync();

            return products;
        }

        public async Task<ProductDetailsViewModel> GetProductByIdAsync(Guid productId)
        {
            try
            {
                var product = await dbContext.Products
                    .Where(p => p.ProductId == productId)
                    .Select(p => new ProductDetailsViewModel
                    {
                        Id = p.ProductId,
                        Name = p.Name,
                        Description = p.Description,
                        ImageUrl = p.ImageUrl,
                        Price = p.Price,
                        ColorName = p.Color.Name,
                        CategoryName = p.Category.Name,
                        QuantityAll = p.ProductSizes.Sum(ps => ps.Quantity), 
                        Sizes = p.ProductSizes.Select(ps => new SizeQuantityViewModel
                        {
                            SizeName = ps.Size.Name,
                            Quantity = ps.Quantity
                        }).ToList()
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
                var product = await dbContext.Products
                    .Where(p => p.Name == name)
                    .Select(p => new ProductDetailsViewModel
                    {
                        Id = p.ProductId,
                        Name = p.Name,
                        Description = p.Description,
                        ImageUrl = p.ImageUrl,
                        Price = p.Price,
                        ColorName = p.Color.Name,
                        CategoryName = p.Category.Name,
                        QuantityAll = p.ProductSizes.Sum(ps => ps.Quantity),
                        Sizes = p.ProductSizes.Select(ps => new SizeQuantityViewModel
                        {
                            SizeName = ps.Size.Name,
                            Quantity = ps.Quantity
                        }).ToList()
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
            var products = await dbContext.Products
                .Where(p => p.Category.Name == categoryName && p.ProductSizes.Sum(ps => ps.Quantity) > 0)
                .Select(p => new ProductViewModel
                {
                    Id = p.ProductId,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Quantity = p.ProductSizes.Sum(ps => ps.Quantity)
                })
                .AsNoTracking()
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
            var category = await dbContext.Categories.FirstOrDefaultAsync(c => c.Name == model.Category)
                            ?? new Category { Name = model.Category };

            var color = await dbContext.Colors.FirstOrDefaultAsync(c => c.Name == model.Color)
                            ?? new Color { Name = model.Color };

            var picture = await mediaService.UploadPictureAsync(model.Photo, model.Name);

            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = picture,
                Price = model.Price,
                Category = category,
                Color = color,
                CreatedOn = DateTime.UtcNow
            };

         
            foreach (var sizeEntry in model.SizesWithQuantities)
            {
                var size = await dbContext.Sizes.FirstOrDefaultAsync(s => s.Name == sizeEntry.Key)
                           ?? new Size { Name = sizeEntry.Key };

                product.ProductSizes.Add(new ProductSize
                {
                    Size = size,
                    Quantity = sizeEntry.Value
                });
            }

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
        }

    }
}
