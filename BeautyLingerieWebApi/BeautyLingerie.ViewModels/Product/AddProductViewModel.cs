﻿namespace BeautyLingerie.ViewModels.Product
{
    using BeautyLingerie.Common;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class AddProductViewModel
    {
        [Required]
        [MaxLength(ValidationalConstants.ProductNameMaxLenght)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(ValidationalConstants.ProductDescriptionMaxLenght)]
        public string Description { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Category { get; set; } = null!;
    
        [Required]
        public string Color { get; set; } = null!;
        [Required]
        public IFormFile Photo { get; set; } = null!;
        public Dictionary<string, int> SizesWithQuantities { get; set; } = new();
       
    }
}
