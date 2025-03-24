namespace BeautyLingerie.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
    using Microsoft.AspNetCore.Authorization;

    [ApiController]
    [Route("/[controller]")]
    public class ProductsController : Controller
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;

        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductViewModel>))]
        public async Task<IActionResult> GetAll()
        {
            var model = await productService.GetAllAsync();
            return Ok(model);
        }
        [HttpGet("{productId}")]
        [ProducesResponseType(200, Type = typeof(ProductDetailsViewModel))]
        public async Task<IActionResult> GetProductById(Guid productId)
        {
            ProductDetailsViewModel model = await productService.GetProductByIdAsync(productId);
            return Ok(model);
        }

        [HttpGet("Name/{productName}")]
        [ProducesResponseType(200, Type = typeof(ProductDetailsViewModel))]
        public async Task<IActionResult> GetProductByName(string productName)
        {
            ProductDetailsViewModel model = await productService.GetProductByNameAsync(productName);
            return Ok(model);
        }

        [HttpGet("Category/{categoryName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductViewModel>))]
   
        public async Task<IActionResult> GetProductsByCategoryName(string categoryName)
        {
            var model = await productService.GetProductsByCategoryNameAsync(categoryName);
            return Ok(model);
        }
        [HttpGet("NewArrivals")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductViewModel>))]
      
        public async Task<IActionResult> GetNewArrivals()
        {
            var model = await productService.GetNewestProducts();
            return Ok(model);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost("Add")]
        public async Task<IActionResult> AddNewProduct([FromBody] AddProductViewModel product)
        {
            await productService.AddProductAsync(product);
            return Ok();
        }

    }

}
