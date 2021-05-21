using GcDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace GcDealership.Context
{
    public class GCDelershipDbContext : DbContext
    {
        public GCDelershipDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vehicle> Cars { get; set; }
    }
}
