using BeautyLingerie.Services.Order.Contracts;
using BeautyLingerie.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;

namespace BeautyLingerie.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class OrderController : Controller
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;

        }
        [HttpPost("/order/add-guest")]
       public async Task<IActionResult> AddGuestOrder([FromBody] AddOrderGuestViewModel model)
        {
            await orderService.AddGuestOrder(model);
            return Ok();
        }
     
    }
}
