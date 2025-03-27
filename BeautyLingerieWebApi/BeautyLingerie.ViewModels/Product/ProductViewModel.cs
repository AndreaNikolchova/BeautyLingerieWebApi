﻿using System.ComponentModel.DataAnnotations;
using BeautyLingerie.Common;
namespace BeautyLingerie.ViewModels.Product
{
    public class ProductViewModel
    {
     
        public Guid Id { get; set; }
    
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
