using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Core.Contracts;
using CourierService.Core.Models.Orders;
using CourierService.Infrastructure.Data.Common.Order;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.Extensions.Logging;

namespace CourierService.Core.Services
{
    public class GetQuickQuoteService :IGetQuickQuoteService
    {
        private readonly OrderRepository repo;


        public async Task<int> Create(GetQuickQuoteModel model)
        {
            var quote = new GetQuickQuote()
            {
                ParcelKg = model.ParcelKg,
                Parts = model.Parts,
                SenderCountry = model.SenderCountry,
                SenderCity = model.SenderCity,
                ReceiverCountry = model.ReceiverCountry,
                ReceiverCity = model.ReceiverCity,
            };

            try
            {
                await repo.AddAsync(quote);
                await repo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
               // logger.LogError(nameof(Create), ex);
                throw new ApplicationException("Database failed to save info", ex);
            }

            return quote.QuickQuoteId;
        }
    }
}
