using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyLingerie.Data.Models
{
    public class ProductSize
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Guid SizeId { get; set; }
        public Size Size { get; set; } = null!;

        public int Quantity { get; set; } 
    }
}
