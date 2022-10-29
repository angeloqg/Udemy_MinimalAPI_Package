using Microsoft.EntityFrameworkCore;

namespace MinimalAPI.Delivery.Context
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options) {}

        public DbSet<Location> Locations => Set<Location>();
    }
}
