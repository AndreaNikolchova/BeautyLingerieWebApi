namespace BeautyLingerieWebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BeautyLingerieWebApi.Data;
    using BeautyLingerieWebApi.Services.MediaService;

    [ApiController]
    [Route("api/product")]
    public class ProductsController : ControllerBase
    {
        private readonly S3Service _s3Service;
        private readonly BeautyLingerieDbContext _context;

        public ProductsController(S3Service s3Service, BeautyLingerieDbContext dbContext)
        {
            _s3Service = s3Service;
            _context = dbContext;
        }

    
     
    }

}
