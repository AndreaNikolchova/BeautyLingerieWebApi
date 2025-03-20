namespace BeautyLingerie.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using BeautyLingerie.Common;

    public class Product
    {
        public Product()
        {
            ProductId = Guid.NewGuid();
        }
        [Key]
        public Guid ProductId { get; set; }

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
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Size))]
        public Guid SizeId { get; set; }
        public Size Size { get; set; }

        [ForeignKey(nameof(Color))]
        public Guid ColorId { get; set; }
        public Color Color { get; set; }
    
        public DateTime CreatedOn { get; set; }

    }
}
