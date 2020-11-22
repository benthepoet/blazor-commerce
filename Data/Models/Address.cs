namespace BlazorCommerce.Data.Models
{
    public class Address 
    {
        public int Id { get; set; }

        public string Addresse { get; set; }

        public string AddressLine { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string StateOrProvince { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}