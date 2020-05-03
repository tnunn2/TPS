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
            var customer = _context.Customers.Find(id) ?? new Customer();

            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.User))
            {
                _context.Add(customer);
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddOrEdit(Customer customer)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetData(int id)
        {
            var customers = _context.Customers.Select(s => new CustomerListViewModel
            {
                Name = s.Name,
                User = s.User,
                SalesPerson = s.SalesPerson,
                PastDueAmount = s.PastDueAmount,
                PhoneNumber = s.PhoneNumber
            });

            return Json(new { data = customers });
        }
    }
}