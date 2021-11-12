using FamilyManagementRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyManagementRestApi.Persistence
{
    public class FamilyDbContext : DbContext
    {
        public DbSet<Family> Families { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = FamilyManagementFamilies.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuring composite keys. 
            modelBuilder.Entity<Family>().HasKey(f => new {f.StreetName, f.HouseNumber});
            modelBuilder.Entity<Job>().HasKey(j => new {j.JobTitle, j.Salary});
        }
    }
}