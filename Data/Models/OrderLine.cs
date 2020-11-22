namespace BlazorCommerce.Data.Models
{
    public class OrderLine
    {
        public int Id { get; set; }

        public int ProductVariantId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}