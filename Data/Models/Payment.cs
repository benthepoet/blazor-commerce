namespace BlazorCommerce.Data.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int PaymentStatusId { get; set; }

        public int PaymentTypeId { get; set; }

        public string Response { get; set; }

        public int OrderId { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}