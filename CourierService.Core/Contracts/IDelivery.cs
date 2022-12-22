using CourierService.Infrastructure.Data.Models.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Contracts
{
    public interface IDelivery
    {

        public int OrderId { get; set; }

        public int? UserId { get; set; }


        public int TrackingId { get; set; }
    }
}
