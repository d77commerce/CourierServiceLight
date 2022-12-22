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
        [Display(Name = "Kg")]
        public double ParcelKg { get; set; }
        public int Parts { get; set; }
        [Display(Name = "From Country")]
        public string SenderCountry { get; set; } = null!;
        [Display(Name = "From Town")]
        public string SenderCity { get; set; } = null!;
        [Display(Name = "To Country")]
        public string ReceiverCountry { get; set; } = null!;
        [Display(Name = "To Town")]
        public string ReceiverCity { get; set; } = null!;
    }
}
