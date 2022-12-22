using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Models.Orders
{
    public class OrderModel
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50,MinimumLength = 5)]
        public string SenderFirstName { get; set; } = null!;
        [Required]
        [Display(Name = "LastName")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderLastName { get; set; } = null!;
        [Required]
        [Display(Name = "Phone No")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderPhone { get; set; } = null!;
        [Display(Name = "Email Address")]
        [EmailAddress]
        [StringLength(50, MinimumLength = 5)]

        public string? SenderMail { get; set; }
        [Required]
        [Display(Name = "Receiver First Name")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverFirstName { get; set; } = null!;
        [Required]
        [Display(Name = "Receiver Last Name")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverLastName { get; set; } = null!;
        [Required]
        [Display(Name = "Receiver Phone No")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverPhone { get; set; } = null!;
        [Required]
        [Display(Name = "Total Kg")]
        [StringLength(50, MinimumLength = 5)]

        public double ParcelKg { get; set; }
        [Required]
        [Display(Name = "How many Parts")]
        [StringLength(50, MinimumLength = 5)]

        public int Parts { get; set; } = 1;
        [Required]
        [Display(Name = "Is it Fragile?")]
        [StringLength(50, MinimumLength = 5)]

        public bool? IsFragile { get; set; } = false;
        [Required]
        [Display(Name = "Country")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderCountry { get; set; } = null!;
        [Required]
        [Display(Name = "Town")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderCity { get; set; } = null!;
        [Required]
        [Display(Name = "Street")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderStreet { get; set; } = null!;
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Address Line 1")]
        public string? SenderAddressLine1 { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Address Line 2")]

        public string? SenderAddressLine2 { get; set; }
        [Required]
        [Display(Name = "Postcode")]
        [StringLength(50, MinimumLength = 5)]

        public string SenderPostcode { get; set; } = null!;
        [Required]
        [Display(Name = "country")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverCountry { get; set; } = null!;
        [Required]
        [Display(Name = "Town")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverCity { get; set; } = null!;
        [Required]
        [Display(Name = "Street")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverStreet { get; set; } = null!;
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Address Line 1")]

        public string? ReceiverAddressLine1 { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Address Line 2")]

        public string? ReceiverAddressLine2 { get; set; }
        [Required]
        [Display(Name = "Postcode")]
        [StringLength(50, MinimumLength = 5)]

        public string ReceiverPostcode { get; set; } = null!;
        [Required]
        [Display(Name = "Your Message !")]
        [StringLength(50, MinimumLength = 5)]

        public string? CustomerMessage { get; set; }
    }
}
