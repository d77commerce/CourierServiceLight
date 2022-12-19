using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierService.Infrastructure.Data.Models.Orders;
using Microsoft.EntityFrameworkCore;

namespace CourierService.Infrastructure.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<GetQuickQuote> GetQuickQuotes { get; set; } = null!;
        public DbSet<Delivery> Deliveries { get; set; } = null!;
    }
}
