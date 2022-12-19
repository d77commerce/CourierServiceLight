using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourierService.Infrastructure.Data.Models.Administration
{
    public class Worker
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

       [Required]
        public int BranchId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; } = null!;
    }
}
