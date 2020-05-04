
namespace TPS.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string AttentionOrCareOf { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string BillingContact { get; set; }
        public string PhoneNumber { get; set; }
        public string SalesPerson { get; set; }
        public string BalanceMethod { get; set; }
        public string TermsCode { get; set; }
        public string CreditLimit { get; set; }
        public decimal? AverageDaysToPay { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? PastDueAmount { get; set; }
        public decimal? HighBalance { get; set; }
        public decimal? Pricing { get; set; }
        public decimal? Discount { get; set; }
        public int? RequiredPoNumber { get; set; }
        public string ShipVia { get; set; }
        public string TaxCode { get; set; }
        public string ShipTo { get; set; }
        public string BillTo { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public int? TaxNumber { get; set; }
        public int? AccountReceivable { get; set; }
        public decimal? SalesPtdHistory { get; set; }
        public decimal? SalesYtdHistory { get; set; }
    }
}
