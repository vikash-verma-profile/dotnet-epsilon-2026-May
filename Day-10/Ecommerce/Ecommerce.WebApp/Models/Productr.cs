namespace Ecommerce.WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDescription { get; set; }

        public string? Category { get; set; }

        public string? ProductImage { get; set; }

        public decimal? ProductDiscount { get; set; }

        public decimal? ProductMrp { get; set; }

        public decimal? ProductSellingPrice { get; set; }
    }
}
