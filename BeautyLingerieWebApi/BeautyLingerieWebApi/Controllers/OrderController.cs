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
        [HttpGet("/Orders/{email}")]
        public async Task<IActionResult> GetOrdersUser(string email)
        {
            return Ok(await orderService.GetOrders(email));
        }
        [HttpGet("/Order/{orderId}")]
        public async Task<IActionResult> GetOrderById(Guid orderId)
        {
            return Ok(await orderService.GetOrderById(orderId));
        }
        [HttpPost("/Order/Add-guest")]
       public async Task<IActionResult> AddGuestOrder([FromBody] AddOrderGuestViewModel model)
        {
            await orderService.AddGuestOrder(model);
            return Ok();
        }
     
    }
}
