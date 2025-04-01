﻿using BeautyLingerie.Common;
using System.ComponentModel.DataAnnotations;

namespace BeautyLingerie.ViewModels.Product
{
    public class ProductDetailsViewModel
    {
       
        public Guid Id { get; set; }
        
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl {  get; set; } = null!; 
        public decimal Price { get; set; }
        public string ColorName { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public int QuantityAll { get; set; } 
    }
}
