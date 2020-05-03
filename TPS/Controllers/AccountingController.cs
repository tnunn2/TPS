using Microsoft.AspNetCore.Mvc;

namespace TPS.Controllers
{
    public class AccountingController : Controller
    {
        public IActionResult CustomerManagement()
        {
            return View();
        }
        public IActionResult AccountManagement()
        {
            return View();
        }
        public IActionResult ReportingAnalytics()
        {
            return View();
        }
        public IActionResult InstantPay()
        {
            return View();
        }
        public IActionResult PortalManagement()
        {
            return View();
        }
    }
}