﻿using BeautyLingerie.ViewModels.Product;

namespace BeautyLingerie.ViewModels.Order
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public decimal TotalSum { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public string Status { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
