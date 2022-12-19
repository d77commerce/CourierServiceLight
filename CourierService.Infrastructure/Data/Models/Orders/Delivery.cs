using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models.Orders
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        public int? UserId { get; set; }

        [Required]
        public int TrackingId { get; set; }

    }
}
