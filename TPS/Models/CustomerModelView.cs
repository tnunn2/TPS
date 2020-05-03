
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TPS.Models
{
    public class CustomerModelView
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Address { get; set; }
        [DisplayName("Attention Or Care Of")]
        public string AttentionOrCareOf { get; set; }
        public string Suite { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        [Required]
        public string ZipCode { get; set; }
        [DisplayName("Billing Contact")]
        public string BillingContact { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
        [DisplayName("Sales Person")]
        public string SalesPerson { get; set; }
        [DisplayName("Balance Method")]
        public string BalanceMethod { get; set; }
        [DisplayName("Terms Code")]
        public string TermsCode { get; set; }
        [DisplayName("Credit Limit")]
        public string CreditLimit { get; set; }
        [DisplayName("Average Days To Pay")]
        public decimal? AverageDaysToPay { get; set; }
        [DisplayName("Current Balance")]
        public decimal? CurrentBalance { get; set; }
        [DisplayName("Past Due Amount")]
        public decimal? PastDueAmount { get; set; }
        [DisplayName("High Balance")]
        public decimal? HighBalance { get; set; }
        public decimal? Pricing { get; set; }
        public decimal? Discount { get; set; }
        [DisplayName("Required P.O. Number")]
        public int? RequiredPoNumber { get; set; }
        [DisplayName("Ship Via")]
        public string ShipVia { get; set; }
        [DisplayName("Tax Code")]
        public string TaxCode { get; set; }
        [DisplayName("Ship To")]
        public string ShipTo { get; set; }
        [DisplayName("Bill To")]
        public string BillTo { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        [DisplayName("Tax Number")]
        public int? TaxNumber { get; set; }
        [DisplayName("Account Receivable")]
        public int? AccountReceivable { get; set; }
        [DisplayName("Sales PTD History")]
        public decimal? SalesPtdHistory { get; set; }
        [DisplayName("Sales YTD History")]
        public decimal? SalesYtdHistory { get; set; }
    }
}

