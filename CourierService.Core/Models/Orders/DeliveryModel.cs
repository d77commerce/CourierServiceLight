using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Core.Contracts;

namespace CourierService.Core.Models.Orders
{
public class DeliveryModel:IDelivery
    {
        [Required]
        public int OrderId { get; set; }
        
        public int? UserId { get; set; }
        [Required]
        public int TrackingId { get; set; }
    }
}
