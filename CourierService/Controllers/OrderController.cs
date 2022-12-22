using CourierService.Infrastructure.Data.Common.Order;
using Microsoft.AspNetCore.Mvc;

namespace CourierService.Controllers
{
    public class OrderController : Controller
    {
        private  readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository _orderRepository)
        {
            orderRepository=_orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        public async Task<IActionResult> GetAllDelivery()
        {
           var model = await orderRepository.get
            return View();
        }
    }
}
