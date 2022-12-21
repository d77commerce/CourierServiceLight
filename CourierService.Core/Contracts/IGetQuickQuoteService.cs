using CourierService.Core.Models.Orders;

namespace CourierService.Core.Contracts
{
    public interface IGetQuickQuoteService
    {
        Task Create (GetQuickQuoteModel model);
    }
}
