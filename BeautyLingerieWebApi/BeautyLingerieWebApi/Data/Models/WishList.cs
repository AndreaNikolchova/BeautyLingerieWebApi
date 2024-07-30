namespace BeautyLingerieWebApi.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class WishList
    {
        public WishList()
        {
            WishListId = Guid.NewGuid();
        }
        [Key]
        public Guid WishListId { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

    }
}
