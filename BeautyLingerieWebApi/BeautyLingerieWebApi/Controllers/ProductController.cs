namespace BeautyLingerie.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerie.Services.Product.Contacts;
    using BeautyLingerie.ViewModels.Product;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
           this.productService = productService;
            
        }
        [HttpGet]
        [ProducesResponseType(200,Type =typeof(IEnumerable<ProductViewModel>))]
        public async Task<IActionResult> GetAll()
        {
            var model = await productService.GetAllAsync();
            return Ok(model);
        }


    }

}
