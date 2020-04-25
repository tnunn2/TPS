using Microsoft.AspNetCore.Mvc;

namespace TPS.Controllers
{
    public class CustomerManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}