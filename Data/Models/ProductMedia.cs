namespace BlazorCommerce.Data.Models
{
    public class ProductMedia
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ContentType { get; set; }

        public string Location { get; set; }
    }
}