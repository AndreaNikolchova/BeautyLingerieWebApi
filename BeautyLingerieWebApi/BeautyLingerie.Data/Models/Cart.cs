using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerie.Data.Models
{
    public class Cart
    {
        public Cart()
        {
            CardId = Guid.NewGuid();
            this.CartProduct = new HashSet<CartProduct>();
        }
        [Key]
        public Guid CardId { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartProduct> CartProduct { get; set; }

    }
}
