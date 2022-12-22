using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
