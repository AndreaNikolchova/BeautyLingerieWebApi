﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class CartProduct
    {
        public CartProduct()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        [ForeignKey(nameof(Cart))]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }


    }
}
