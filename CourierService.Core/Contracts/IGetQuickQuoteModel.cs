using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Contracts
{
    public interface IGetQuickQuoteModel
    {
        public double ParcelKg { get; set; }
        public int Parts { get; set; }
        public string SenderCountry { get; set; }
        public string SenderCity { get; set; }
        public string ReceiverCountry { get; set; }
        public string ReceiverCity { get; set; }
    }
}
