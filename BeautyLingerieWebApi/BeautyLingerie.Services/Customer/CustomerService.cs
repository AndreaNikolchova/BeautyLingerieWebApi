namespace BeautyLingerie.Services.Customer
{
    using BeautyLingerie.Data;
    using BeautyLingerie.Services.Customer.Contracts;
    using BeautyLingerie.ViewModels.Customer;
    using BeautyLingerie.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class CustomerService : ICustomerService
    {
        public BeautyLingerieDbContext dbContext { get; set; }
        private readonly UserManager<IdentityUser> userManager;

        public CustomerService(BeautyLingerieDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        public async Task AddCustomerAsync(AddCustomerViewModel model)
        {
            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
               
                Customer customer = new Customer
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserId = user.Id
                };

                
                dbContext.Customers.Add(customer);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                
                throw new Exception(string.Join("; ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}
