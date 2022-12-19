using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Common.Order
{
    public class OrderRepository : Repository, IOrderRepository
    {
        public OrderRepository(OrderDbContext context)
        {
            this.Context = context;
        }
    }
}
