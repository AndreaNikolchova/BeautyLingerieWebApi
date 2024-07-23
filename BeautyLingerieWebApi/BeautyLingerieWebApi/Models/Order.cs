using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public decimal TotalSum { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
