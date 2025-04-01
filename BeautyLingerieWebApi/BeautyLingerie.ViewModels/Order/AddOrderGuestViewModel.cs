

using BeautyLingerie.ViewModels.Product;

namespace BeautyLingerie.ViewModels.Order
{
    public class AddOrderGuestViewModel
    {
        public decimal TotalSum { get; set; }
        public List<OrderProductViewModel> Products { get; set; } =null!;
        public DateTime CreatedOn { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;    

    }
}
