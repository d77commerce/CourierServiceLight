using CourierService.Core.Contracts;
using CourierService.Core.Models.Orders;
using CourierService.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class QuoteController : Controller
    {
        private readonly GetQuickQuoteService quickQuoteService;

      
        // GET: QuoteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuoteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuoteController/Create


        // POST: QuoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetQuote(GetQuickQuoteModel getQuickQuote)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await quickQuoteService.Create(getQuickQuote);
                }

            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    
        
    }
}
