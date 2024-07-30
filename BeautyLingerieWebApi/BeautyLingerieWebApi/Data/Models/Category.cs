namespace BeautyLingerieWebApi.Data.Models
{
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
        public string Name { get; set; } = null!;

    }
}
