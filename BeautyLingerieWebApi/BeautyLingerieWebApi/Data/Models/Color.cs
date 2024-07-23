using System.ComponentModel.DataAnnotations;

namespace BeautyLingerieWebApi.Data.Models
{
    public class Color
    {
        public Color()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string HEXCode { get; set; } = null!;
    }
}
