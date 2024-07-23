﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class OrderProduct
    {

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

    }
}
