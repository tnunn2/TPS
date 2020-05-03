namespace TPS.Models
{
    public class CustomerListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string SalesPerson { get; set; }
        public decimal PastDueAmount { get; set; }
        public string PhoneNumber { get; set; }
    }
}
