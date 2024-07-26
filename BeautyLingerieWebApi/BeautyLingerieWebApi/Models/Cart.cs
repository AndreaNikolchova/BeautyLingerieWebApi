﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class Cart
    {
        public Cart()
        {
            this.CardId = Guid.NewGuid();
        }
        [Key]
        public Guid CardId { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartProduct> CartProduct { get; set; }

    }
}
