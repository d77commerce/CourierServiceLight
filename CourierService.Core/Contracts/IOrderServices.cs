using CourierService.Infrastructure.Data.Models.Orders;

namespace CourierService.Core.Contracts
{
    public interface IOrderServices
   {
     public Task<IEnumerable<Order>> GetAllOrders();
   }
}
