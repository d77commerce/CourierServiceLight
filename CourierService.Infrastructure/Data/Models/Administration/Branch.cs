using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models.Administration
{
    public class Branch
    {
        public Branch()
        {
            Workers = new List<Worker>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!; 
        [Required]
        public int ManagerId { get; set; }

        [ForeignKey(nameof(ManagerId))]
        public Manager Manager { get; set; }=null!;
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
