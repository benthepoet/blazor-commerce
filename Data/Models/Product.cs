using System.Collections.Generic;

namespace BlazorCommerce.Data.Models
{
    public class Product 
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<ProductVariant> ProductVariants { get; set; }
    }
}