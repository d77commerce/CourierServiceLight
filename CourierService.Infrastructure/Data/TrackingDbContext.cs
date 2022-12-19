using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Tracking;
using Microsoft.EntityFrameworkCore;

namespace CourierService.Infrastructure.Data
{
    public class TrackingDbContext :DbContext
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options)
        :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tracking> Tracking { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;
    }
}
