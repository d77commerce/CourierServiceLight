using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Administration;
using Microsoft.EntityFrameworkCore;

namespace CourierService.Infrastructure.Data
{
    public class AdministrationDbContext : DbContext
    {
        public AdministrationDbContext(DbContextOptions<AdministrationDbContext> options)
        : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Branch> Branches { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; }=null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}
