using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Enums;

namespace CourierService.Infrastructure.Data.Models.Tracking
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public StatusEnum EnumStatus { get; set; }
        [Required]
        [ForeignKey(nameof(Tracking))]
        public int  TrackingId { get; set; }

        public virtual Tracking Tracking { get; set; } = null!;
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        public string Info { get; set; } = string.Empty;
    }
}
