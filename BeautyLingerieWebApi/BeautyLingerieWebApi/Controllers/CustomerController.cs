using BeautyLingerie.Services.Customer.Contracts;
using BeautyLingerie.Services.Product;
using BeautyLingerie.Services.Product.Contacts;
using BeautyLingerie.ViewModels.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BeautyLingerie.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class CustomerController : Controller
    {
        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;

        }
        [HttpPost("Add")]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerViewModel model)
        {
            try{
                await customerService.AddCustomerAsync(model);

            }
            catch (Exception ex) 
            {
                return BadRequest(new { errors = ex.Message });
            }
            return Ok();
        }
    }
}
