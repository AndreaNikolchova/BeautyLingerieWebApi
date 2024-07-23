namespace BeautyLingerieWebApi.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Size
    {
        public Size()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
