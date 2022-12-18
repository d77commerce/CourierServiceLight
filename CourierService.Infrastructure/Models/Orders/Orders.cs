using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Models.Orders
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        [Required] public string TrackingId { get; set; } = null!;
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        public string SenderFirstName { get; set; } = null!;
        [Required]
        public string SenderLastName { get; set; } = null!;
        [Required]
        public string SenderPhone { get; set; } = null!;
        public string? SenderMail { get; set; }
        [Required]
        public string ReceiverFirstName { get; set; } = null!;
        [Required]
        public string ReceiverLastName { get; set; } = null!;
        [Required]
        public string ReceiverPhone { get; set; } = null!;
        [Required]
        public double ParcelKg { get; set; }
        [Required]
        public int Parts { get; set; } = 1;
        [Required]
        public bool? IsFragile { get; set; } = false;
        [Required]
        public string SenderCountry { get; set; } = null!;
        [Required]
        public string SenderCity { get; set; } = null!;
        [Required]
        public string SenderStreet { get; set; } = null!;
        public string? SenderAddressLine1 { get; set; }
        public string? SenderAddressLine2 { get; set; }
        [Required]
        public string SenderPostcode { get; set; } = null!;
        [Required]
        public string ReceiverCountry { get; set; } = null!;
        [Required]
        public string ReceiverCity { get; set; } = null!;
        [Required]
        public string ReceiverStreet { get; set; } = null!;
        public string? ReceiverAddressLine1 { get; set; }
        public string? ReceiverAddressLine2 { get; set; }
        [Required]
        public string ReceiverPostcode { get; set; } = null!;
        public string? CustomerMessage { get; set; }
    }
}
