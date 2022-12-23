using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Core.Contracts;
using CourierService.Core.Models.Orders;
using CourierService.Infrastructure.Data.Common.Order;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.EntityFrameworkCore;

namespace CourierService.Core.Services
{
    public class OrderServices:IOrderServices
    {
        private readonly IOrderRepository repo;

        public OrderServices(IOrderRepository _repo)
        {
            repo= _repo;
        }
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await repo.AllReadonly<Order>().ToListAsync();
        }
    }


}

