using Microsoft.EntityFrameworkCore;
using PALOITChallenge.Models;

namespace PALOITChallenge
{
    public class ZombiesData : DbContext
    {
        public ZombiesData()
        {
        }

        public ZombiesData(DbContextOptions<ZombiesData> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<IllnessTableModel> Diseasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IllnessTableModel>(e =>
            {
                e.HasKey(p => p.IllnessId);
            });
            modelBuilder.Entity<Patient>(e =>
            {
                e.HasKey(p => p.Id);
            });


        }
    }
}
