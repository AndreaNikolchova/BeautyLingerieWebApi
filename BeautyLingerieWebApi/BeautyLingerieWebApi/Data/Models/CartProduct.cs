using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyLingerieWebApi.Models
{
    public class CartProduct
    {
      
        [ForeignKey(nameof(Cart))]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;


    }
}
