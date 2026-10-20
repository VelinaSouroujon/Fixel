using Fixel.Data.Configurations;
using Fixel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<RepairTicket> RepairTickets { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<DeviceModel> DeviceModels { get; set; }

        public DbSet<DeviceType> DeviceTypes { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RepairTicketConfiguration());
        }
    }
}
