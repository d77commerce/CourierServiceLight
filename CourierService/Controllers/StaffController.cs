using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
