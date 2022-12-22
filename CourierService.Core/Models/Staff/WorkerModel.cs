using CourierService.Infrastructure.Data.Models.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Core.Models.Staff
{
    public class WorkerModel
    {
       
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Mail { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string PhoneNo { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string UserId { get; set; } = null!;

        [Required]
        public int BranchId { get; set; }

      
    }
}
