using System.ComponentModel.DataAnnotations;

namespace BeautyLingerieWebApi.Models
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
        [Required]
        public string HEXCode { get; set; } = null!;
    }
}
