using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models.Administration

{
     public class Manager
    {
      
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Mail { get; set; } = null!;

        [Required]
        public string PhoneNo { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
       

    }
}
