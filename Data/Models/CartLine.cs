using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCommerce.Data.Models
{
    public class CartLine
    {
        public int Id { get; set; }

        public Guid CartId { get; set; }

        [Required]
        public int ProductVariantId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}