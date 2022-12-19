using CourierService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CourierService.Core.Contracts;
using CourierService.Core.Models.Orders;
using CourierService.Core.Services;

namespace CourierService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetQuickQuoteService quoteService;
        private readonly IGetQuickQuoteModel qouteModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Quote()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Quote(GetQuickQuoteModel _model)
        {
            if (ModelState.IsValid)
            {
                var model = _model;
               await quoteService.Create(model);
                
               // dbCategoryContext.Categories.Add(newObject);
              //  await dbCategoryContext.SaveChangesAsync();
                //TempData["success"] = " create successfully Quote";
                return RedirectToAction(nameof(Quote));
            }

            return View();

        }
    }
}