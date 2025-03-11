using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerie.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderId = Guid.NewGuid();
            this.Products =  new List<Product>();   
        }
        public Guid OrderId { get; set; }
        public decimal TotalSum { get; set; }
        public DateTime CreatedOn { get; set; }
        public IReadOnlyCollection<Product> Products { get; set; }

    }
}
