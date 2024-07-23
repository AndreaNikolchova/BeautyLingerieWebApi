namespace BeautyLingerieWebApi.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNetCore.Identity;
 
    public class Customer
    {
        public Customer()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
        [Required]
      
        public string FirstName { get; set; } = null!;
        [Required] 
        public string LastName { get; set; } = null!;
        [Required]
       
        public string Address { get; set; } = null!;
        [Required]
        
        public string TownName { get; set; } = null!;

    }
}
