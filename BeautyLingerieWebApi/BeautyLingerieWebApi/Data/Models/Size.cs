namespace BeautyLingerieWebApi.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Size
    {
        public Size()
        {
            SizeId = Guid.NewGuid();
        }
        [Key]
        public Guid SizeId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
