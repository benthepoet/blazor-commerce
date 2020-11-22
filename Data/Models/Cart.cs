using System.Collections.Generic;

namespace BlazorCommerce.Data.Models
{
    public class Cart 
    {
        public int Id { get; set; }

        public string SessionId { get; set; }

        public List<CartLine> CartLines { get; set; }
    }
}