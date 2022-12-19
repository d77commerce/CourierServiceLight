using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models.Tracking
{
    public class Tracking
    {
        public Tracking()
        {
            StatusCollection = new List<Status>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string TrackingNo { get; set; } = null!;
        [Required]
        public string DeliveryPostcode { get; set; }= null!;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string? UserId { get; set; }
        [Required]
        public virtual ICollection<Status> StatusCollection { get; set; } = null!;
        [Required]
        public string Info { get; set; } = "Thanks ! ! !";
    }
}
