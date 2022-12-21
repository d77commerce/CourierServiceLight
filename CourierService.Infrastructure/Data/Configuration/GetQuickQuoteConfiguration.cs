using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourierService.Infrastructure.Data.Configuration
{
    internal class GetQuickQuoteConfiguration : IEntityTypeConfiguration<GetQuickQuote>
    {
        public void Configure(EntityTypeBuilder<GetQuickQuote> builder)
        {
            builder.HasData(new GetQuickQuote()
            {
                Id = 1,
                ParcelKg = 10,
                Parts = 2,
                SenderCountry = "Bulgaria",
                SenderCity = "Sofia",
                ReceiverCountry = "Bulgaria",
                ReceiverCity = "Lovech"
            });


        }
    }
}
