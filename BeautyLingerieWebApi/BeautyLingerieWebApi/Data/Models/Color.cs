using System.ComponentModel.DataAnnotations;

namespace BeautyLingerieWebApi.Data.Models
{
    public class Color
    {
        public Color()
        {
            ColorId = Guid.NewGuid();
        }
        [Key]
        public Guid ColorId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
