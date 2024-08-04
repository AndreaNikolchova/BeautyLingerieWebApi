namespace BeautyLingerie.Data.Models
{
    using BeautyLingerie.Common;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public Category()
        {
            CategoryId = Guid.NewGuid();
        }

        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(ValidationalConstants.CategoryNameMaxSize)]
        public string Name { get; set; } = null!;

    }
}
