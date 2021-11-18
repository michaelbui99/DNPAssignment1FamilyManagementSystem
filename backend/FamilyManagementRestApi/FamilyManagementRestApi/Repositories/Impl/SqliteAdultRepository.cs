using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class SqliteAdultRepository : IAdultsRepository
    {
            private FamilyDbContext ctx;

            public SqliteAdultRepository(FamilyDbContext ctx)
            {
                    this.ctx = ctx;
            }

            public async Task<IEnumerable<Adult>> GetAdultsAsync()
        {
           
                return ctx.Families.SelectMany(f => f.Adults).AsEnumerable(); 
            
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            
                return await ctx.Families.SelectMany(f => f.Adults).FirstOrDefaultAsync(a => a.Id == id); 
            
        }

        public async Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult)
        {
            
                Family existingFamily = await ctx.Families.FirstOrDefaultAsync(f => f.StreetName == family.StreetName && f.HouseNumber == family.HouseNumber);
                existingFamily.Adults.Add(adult);
                await ctx.SaveChangesAsync(); 
                return adult;
            
        }

        public async Task<Adult> RemoveAdultAsync(int adultId)
        {
           
                Adult adultToBeRemoved = await ctx.Adults.FindAsync(adultId);
                ctx.Adults.Remove(adultToBeRemoved);
                await ctx.SaveChangesAsync();
                return adultToBeRemoved; 
            
        }
    }
}