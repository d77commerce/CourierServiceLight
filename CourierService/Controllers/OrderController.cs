using CourierService.Core.Contracts;
using CourierService.Infrastructure.Data.Common.Order;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class OrderController : Controller
    {
        private  readonly IOrderServices services;

        public OrderController(IOrderServices _services)
        {
            services = _services;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllDelivery()
        {
            var model = await services.GetAllOrders();
            return View(model);
        }
    }
}
