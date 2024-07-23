namespace BeautyLingerieWebApi.Data.Models
{
  using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity {  get; set; }
        [Required]
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Type { get; set; } = null!;

    }
}
