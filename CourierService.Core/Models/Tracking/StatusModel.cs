using CourierService.Infrastructure.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Models.Tracking
{
    public class StatusModel
    {
        
        [Required]
        public StatusEnum EnumStatus { get; set; }
        [Required]
        public int TrackingId { get; set; }
        [Required]
        public string Info { get; set; } = string.Empty;
    }
}
