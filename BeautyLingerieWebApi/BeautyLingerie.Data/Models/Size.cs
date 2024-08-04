namespace BeautyLingerie.Data.Models
{
    using BeautyLingerie.Common;
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
        [MaxLength(ValidationalConstants.SizeNameMaxSize)]
        public string Name { get; set; } = null!;
    }
}
