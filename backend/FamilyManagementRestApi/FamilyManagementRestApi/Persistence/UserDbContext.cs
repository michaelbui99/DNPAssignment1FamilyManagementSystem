using FamilyManagementRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyManagementRestApi.Persistence
{
    /*
     * Users have their DbContext since users have no relations to other entities. 
     */
    
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = FamilyManagementUsers.db"); 
        }
    }
}