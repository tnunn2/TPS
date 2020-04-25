using Microsoft.EntityFrameworkCore;
using TPS.Models;

namespace TPS.Data
{
    public class TpsDbContext : DbContext
    {
        public TpsDbContext(DbContextOptions<TpsDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers", schema: "CustomerManagement");
        }
    }
}
