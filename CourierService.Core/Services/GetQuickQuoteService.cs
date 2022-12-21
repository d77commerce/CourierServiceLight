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
        private readonly IOrderRepository repository;
        private readonly GetQuickQuoteModel getQuickQuoteModel;

        public GetQuickQuoteService(IOrderRepository _repository, GetQuickQuoteModel getQuickQuoteModel)
        {
           this.repository = _repository;
            this.getQuickQuoteModel = getQuickQuoteModel;
        }
        public async Task Create(GetQuickQuoteModel model)
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
                await repository.AddAsync(quote);
                await repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
               // logger.LogError(nameof(Create), ex);
                throw new ApplicationException("Database failed to save info", ex);
            }

        }
    }
}
