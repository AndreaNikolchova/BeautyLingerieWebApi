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
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<OrderViewModel>))]
        public async Task<IActionResult> GetAll()
        {
            var model = await orderService.GetAllAsync();
            return Ok(model);
        }
        [HttpGet("{orderId}")]
        [ProducesResponseType(200, Type = typeof(OrderViewModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetOrderById(Guid orderId)
        {
            var model = await orderService.GetOrderByIdAsync(orderId);
            return Ok(model);
        }
    }
}
