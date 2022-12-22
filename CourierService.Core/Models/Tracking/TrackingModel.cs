using CourierService.Infrastructure.Data.Models.Tracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Models.Tracking
{
    public class TrackingModel
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        public string TrackingNo { get; set; } = null!;
        [Required]
        public string DeliveryPostcode { get; set; } = null!;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string? UserId { get; set; }
      
        [Required]
        public string Info { get; set; } = "Thanks ! ! !";
    }
}
