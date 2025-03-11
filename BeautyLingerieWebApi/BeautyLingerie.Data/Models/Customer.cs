namespace BeautyLingerie.Data.Models
{
    using BeautyLingerie.Common;
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer
    {
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }

        [Key]
        public Guid CustomerId { get; set; }
        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
      
        [Required]
        [MaxLength(ValidationalConstants.CustomerNameMaxSize)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(ValidationalConstants.CustomerNameMaxSize)]
        public string LastName { get; set; } = null!;
      
    }
}

