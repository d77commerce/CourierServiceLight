using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Core.Contracts;

namespace CourierService.Core.Models.Orders
{
   public class GetQuickQuoteModel :IGetQuickQuoteModel
   
    {
        public double ParcelKg { get; set; }
        public int Parts { get; set; }
        public string SenderCountry { get; set; } = null!;
        public string SenderCity { get; set; } = null!;
        public string ReceiverCountry { get; set; } = null!;
        public string ReceiverCity { get; set; } = null!;
    }
}
