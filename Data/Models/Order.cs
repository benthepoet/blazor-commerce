using System;
using System.Collections.Generic;

namespace BlazorCommerce.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int OrderStatusId { get; set; }

        public int UserId { get; set; }

        public int ShipMethodId { get; set; }

        public int ShipAddressId { get; set; }

        public int BillAddressId { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }    
}