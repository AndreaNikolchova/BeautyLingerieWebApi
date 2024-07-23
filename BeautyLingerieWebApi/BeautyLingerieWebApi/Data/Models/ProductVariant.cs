
namespace BeautyLingerieWebApi.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductVariant
    {
        public ProductVariant()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey(nameof(Size))]
        public Guid SizeId { get; set; }
        public Size Size { get; set; }

        [ForeignKey(nameof(Color))]
        public Guid ColorId { get; set; }
        public Color Color  { get; set; }

        [Required]
        public int Quantity {  get; set; }

    }
}
