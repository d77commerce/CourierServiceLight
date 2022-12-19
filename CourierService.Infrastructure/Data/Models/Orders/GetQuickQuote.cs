using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models.Orders
{
    public class GetQuickQuote
    {
        [Key]
        public int QuickQuoteId { get; set; }
       
        public double ParcelKg { get; set; }
        [Required]
        public int Parts { get; set; } = 1;
        [Required]
       public string SenderCountry { get; set; } = null!;
        [Required]
        public string SenderCity { get; set; } = null!;
        [Required]
        public string ReceiverCountry { get; set; } = null!;
        [Required]
        public string ReceiverCity { get; set; } = null!;
    }
}
