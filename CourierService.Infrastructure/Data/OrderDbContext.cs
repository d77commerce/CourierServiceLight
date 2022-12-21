using CourierService.Infrastructure.Data.Configuration;
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
            builder.ApplyConfiguration(new GetQuickQuoteConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<GetQuickQuote> GetQuickQuotes { get; set; } = null!;
        public DbSet<Delivery> Deliveries { get; set; } = null!;
    }
}
