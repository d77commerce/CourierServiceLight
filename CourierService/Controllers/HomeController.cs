using CourierService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CourierService.Core.Contracts;
using CourierService.Core.Models.Orders;
using CourierService.Core.Services;
using CourierService.Infrastructure.Data.Common.Order;

namespace CourierService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetQuickQuoteService quoteService ;
        private readonly OrderRepository repository;
       

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
        [ValidateAntiForgeryToken]
        public async Task IActionResulQuote (GetQuickQuoteModel model)
        {
            if (ModelState.IsValid)
            {
            
            await quoteService.Create(model);

                
               // dbCategoryContext.Categories.Add(newObject);
              //  await dbCategoryContext.SaveChangesAsync();
                //TempData["success"] = " create successfully Quote";
                
            }
            
        }
    }
}