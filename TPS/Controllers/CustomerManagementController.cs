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
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var customer = _context.Customers.Find(id);

                if (customer != null)
                {
                    _context.Remove(customer);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            CustomerModelView customerViewModel = new CustomerModelView();
            if (id > 0)
            {
                var customer = _context.Customers.Find(id) ?? new Customer();

                customerViewModel = new CustomerModelView
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    User = customer.User,
                    Address = customer.Address,
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CustomerModelView customerViewModel = new CustomerModelView();

            if (id != 0)
            {
                var customer = _context.Customers.Find(id);

                customerViewModel = new CustomerModelView
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    User = customer.User,
                    Address = customer.Address,
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
                FirstName = customerViewModel.FirstName,
                LastName = customerViewModel.LastName,
                User = customerViewModel.User,
                Address = customerViewModel.Address,
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

            if (customer.CustomerId <= 0)
            {
                _context.Add(customer);
            }
            else
            {
                _context.Update(customer);
            }

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
                FirstName = s.FirstName,
                LastName = s.LastName,
                User = s.User,
                PhoneNumber = s.PhoneNumber
            });

            return Json(new { data = customers });
        }
    }
}