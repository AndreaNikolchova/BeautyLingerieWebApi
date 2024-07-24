using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class Cart
    {
        public Cart()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartProduct> CartProduct { get; set; }

    }
}
