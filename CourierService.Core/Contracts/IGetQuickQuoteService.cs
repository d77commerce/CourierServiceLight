using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Core.Models.Orders;

namespace CourierService.Core.Contracts
{
    public interface IGetQuickQuoteService
    {
        Task<int> Create(GetQuickQuoteModel model);
    }
}
