namespace BeautyLingerie.ViewModels.Product
{
    using Microsoft.AspNetCore.Http;
    public class AddProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
        public IFormFile Photo { get; set; } = null!;
    }
}
