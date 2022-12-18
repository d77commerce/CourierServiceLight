using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Models.Enums;

namespace CourierService.Infrastructure.Models.Tracking
{
   public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public StatusEnum EnumStatus { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        public string Info { get; set; } = string.Empty;
    }
}
