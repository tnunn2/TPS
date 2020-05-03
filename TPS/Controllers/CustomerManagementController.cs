using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TPS.Data;
using TPS.Models;

namespace TPS.Controllers
{
    public class CustomerManagementController : Controller
    {
        private readonly TpsDbContext _context;
        public CustomerManagementController(TpsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id = 0)
        {
            CustomerModelView customerViewModel = new CustomerModelView();

            if (id != 0)
            {
                var customer = _context.Customers.Find(id);

                customerViewModel = new CustomerModelView
                {
                    CustomerId = customer.CustomerId,
                    Name = customer.Name,
                    User = customer.User,
                    Address = customer.Name,
                    AttentionOrCareOf = customer.AttentionOrCareOf,
                    Suite = customer.Suite,
                    City = customer.City,
                    State = customer.State,
                    ZipCode = customer.ZipCode,
                    BillingContact = customer.BillingContact,
                    PhoneNumber = customer.PhoneNumber,
                    SalesPerson = customer.SalesPerson,
                    BalanceMethod = customer.BalanceMethod,
                    TermsCode = customer.TermsCode,
                    CreditLimit = customer.CreditLimit,
                    AverageDaysToPay = customer.AverageDaysToPay,
                    CurrentBalance = customer.CurrentBalance,
                    PastDueAmount = customer.PastDueAmount,
                    HighBalance = customer.HighBalance,
                    Pricing = customer.Pricing,
                    Discount = customer.Discount,
                    RequiredPoNumber = customer.RequiredPoNumber,
                    ShipVia = customer.ShipVia,
                    TaxCode = customer.TaxCode,
                    ShipTo = customer.ShipTo,
                    BillTo = customer.BillTo,
                    Type = customer.Type,
                    Group = customer.Group,
                    TaxNumber = customer.TaxNumber,
                    AccountReceivable = customer.AccountReceivable,
                    SalesPtdHistory = customer.SalesPtdHistory,
                    SalesYtdHistory = customer.SalesYtdHistory
                };
            }

            return View(customerViewModel);
        }

        [HttpPost]
        public IActionResult Edit(CustomerModelView customerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(customerViewModel);
            }

            var customer = new Customer
            {
                CustomerId = customerViewModel.CustomerId,
                Name = customerViewModel.Name,
                User = customerViewModel.User,
                Address = customerViewModel.Name,
                AttentionOrCareOf = customerViewModel.AttentionOrCareOf,
                Suite = customerViewModel.Suite,
                City = customerViewModel.City,
                State = customerViewModel.State,
                ZipCode = customerViewModel.ZipCode,
                BillingContact = customerViewModel.BillingContact,
                PhoneNumber = customerViewModel.PhoneNumber,
                SalesPerson = customerViewModel.SalesPerson,
                BalanceMethod = customerViewModel.BalanceMethod,
                TermsCode = customerViewModel.TermsCode,
                CreditLimit = customerViewModel.CreditLimit,
                AverageDaysToPay = customerViewModel.AverageDaysToPay,
                CurrentBalance = customerViewModel.CurrentBalance,
                PastDueAmount = customerViewModel.PastDueAmount,
                HighBalance = customerViewModel.HighBalance,
                Pricing = customerViewModel.Pricing,
                Discount = customerViewModel.Discount,
                RequiredPoNumber = customerViewModel.RequiredPoNumber,
                ShipVia = customerViewModel.ShipVia,
                TaxCode = customerViewModel.TaxCode,
                ShipTo = customerViewModel.ShipTo,
                BillTo = customerViewModel.BillTo,
                Type = customerViewModel.Type,
                Group = customerViewModel.Group,
                TaxNumber = customerViewModel.TaxNumber,
                AccountReceivable = customerViewModel.AccountReceivable,
                SalesPtdHistory = customerViewModel.SalesPtdHistory,
                SalesYtdHistory = customerViewModel.SalesYtdHistory
            };
            _context.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddOrEdit(Customer customer)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var customers = _context.Customers.Select(s => new CustomerListViewModel
            {
                Id = s.CustomerId,
                Name = s.Name,
                User = s.User,
                SalesPerson = s.SalesPerson,
                PastDueAmount = s.PastDueAmount.HasValue ? s.PastDueAmount.Value : 0,
                PhoneNumber = s.PhoneNumber
            });

            return Json(new { data = customers });
        }
    }
}