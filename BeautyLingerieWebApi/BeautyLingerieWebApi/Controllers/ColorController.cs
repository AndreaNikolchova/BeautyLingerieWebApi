using BeautyLingerie.Services.Color.Contracts;
using BeautyLingerie.ViewModels.Color;

using Microsoft.AspNetCore.Mvc;

namespace BeautyLingerie.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ColorController : Controller
    {
        private IColorService colorService;

        public ColorController(IColorService colorService)
        {
            this.colorService = colorService;

        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ColorViewModel>))]
        public async Task<IActionResult> GetAll()
        {
            var model = await colorService.GetAllAsync();
            return Ok(model);
        }
    }
}
