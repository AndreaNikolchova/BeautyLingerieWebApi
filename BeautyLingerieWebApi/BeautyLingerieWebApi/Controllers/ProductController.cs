namespace BeautyLingerie.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;
    using Microsoft.AspNetCore.Authorization;
    using System.Security.Claims;

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
        [HttpGet("NewArrivals")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ProductViewModel>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> getNewArrivals()
        {
            var model = await productService.GetNewestProducts();
            return Ok(model);
        }
        [Authorize]
        [HttpPost("AddToCart")]
        public async Task<IActionResult> AddToCart([FromBody] string productId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized();
            }
            try
            {
                await productService.AddToCartAsync(Guid.Parse(productId), userId);
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }
        [Authorize]
        [HttpGet("Cart")]
        public async Task<IActionResult> getCartProducts()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized(new { });
            }
            try
            {
                var products  = await productService.GetProductsInCartAsync(userId);
                return Ok(products);
            }
            catch
            {
                return BadRequest();
            }


        }
    }

}
