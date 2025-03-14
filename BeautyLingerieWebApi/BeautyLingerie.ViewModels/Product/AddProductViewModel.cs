namespace BeautyLingerie.ViewModels.Product
{
    using BeautyLingerie.Common;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class AddProductViewModel
    {
        public Guid Id { get; set; }
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
        public string Size { get; set; } = null!;
        [Required]
        public string Color { get; set; } = null!;
        public IFormFile Photo { get; set; } = null!;
    }
}
