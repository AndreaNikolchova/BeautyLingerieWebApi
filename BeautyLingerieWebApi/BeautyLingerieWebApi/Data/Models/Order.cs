using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Data.Models
{
    public class Order
    {
        public Order()
        {
            OrderId = Guid.NewGuid();
        }
        public Guid OrderId { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public decimal TotalSum { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
