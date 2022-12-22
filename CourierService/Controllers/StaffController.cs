using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult AddWorker()
        {
            return View();
        }
    }
}
