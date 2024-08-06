using BeautyLingerie.ViewModels.Customer;

namespace BeautyLingerie.Services.Customer.Contracts
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(AddCustomerViewModel model);
    }
}
