using Microsoft.EntityFrameworkCore;
using EfCorePerformanceTest.Models;

namespace EfCorePerformanceTest.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DataRecord> DataRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PerformanceTestDb;Trusted_Connection=True;");
        }
    }
}
