using CourierService.Core.Models.Tracking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class TrackingController : Controller
    {
     
        [HttpGet]
        [AllowAnonymous]
       public IActionResult Index()
        {
          //  var model = new TrackingModel();
            return View();
        }
    }
}
