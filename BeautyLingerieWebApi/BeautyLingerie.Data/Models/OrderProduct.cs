using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerie.Data.Models
{
    public class OrderProduct
    {
        [Key]
        public Guid OrderProductId { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

      
        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal PriceAtOrderTime { get; set; }
    }
}
