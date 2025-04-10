﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerie.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderId = Guid.NewGuid();
            this.OrderProducts = new List<OrderProduct>(); 
        }

        public Guid OrderId { get; set; }

        [Required]
        public decimal TotalSum { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public string? UserId { get; set; }

        [StringLength(255)]
        public string FullName { get; set; } = null!;

        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [StringLength(50)]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(500)]
        public string ShippingAddress { get; set; } = null!;

        [StringLength(50)]
        public string Status { get; set; } = null!;

        public List<OrderProduct> OrderProducts { get; set; }
    }

}
