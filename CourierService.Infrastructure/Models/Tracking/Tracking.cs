using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Models.Tracking
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
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Required]
        public virtual ICollection<Status> StatusCollection { get; set; } = null!;
        [Required]
        public string Info { get; set; } = "Thanks ! ! !";
    }
}
