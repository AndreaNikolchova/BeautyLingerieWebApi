namespace BeautyLingerieWebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerieWebApi.Data;
    using BeautyLingerieWebApi.Services.MediaService;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly S3Service _s3Service;
        private readonly BeautyLingerieDbContext _context;

        public ProductsController(S3Service s3Service, BeautyLingerieDbContext dbContext)
        {
            _s3Service = s3Service;
            _context = dbContext;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadImage(IFormFile file, int productId)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File is empty");
            }

            var url = await _s3Service.UploadFileAsync(file);

            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            product.ImageUrl = url;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return Ok(new { url });
        }
    }

}
