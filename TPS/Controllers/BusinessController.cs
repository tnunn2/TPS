using Microsoft.AspNetCore.Mvc;

namespace TPS.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}