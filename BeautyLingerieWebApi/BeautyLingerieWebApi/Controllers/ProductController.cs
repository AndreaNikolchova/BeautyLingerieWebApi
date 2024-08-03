namespace BeautyLingerie.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
  

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
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetProductById(Guid productId)
        {
            ProductDetailsViewModel model;
            try
            {
                model = await productService.GetProductByIdAsync(productId);
            }
            catch (ArgumentException ae)
            {
                return NotFound(ae.Message);
            }
            return Ok(model);
        }

        [HttpGet("Category/{categoryName}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductViewModel>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetProductsByCategoryName(string categoryName)
        {
            var model = await productService.GetProductsByCategoryNameAsync(categoryName);
            return Ok(model);
        }
    }

}
