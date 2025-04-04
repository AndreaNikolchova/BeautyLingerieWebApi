namespace BeautyLingerie.Data.Models
{
    using BeautyLingerie.Common;
    using System.ComponentModel.DataAnnotations;
    public class Size
    {
        public Size()
        {
            SizeId = Guid.NewGuid();
            ProductSizes = new List<ProductSize>(); 
        }

        [Key]
        public Guid SizeId { get; set; }

        [Required]
        [MaxLength(ValidationalConstants.SizeNameMaxSize)]
        public string Name { get; set; } = null!;

        public List<ProductSize> ProductSizes { get; set; } 
    }
}
