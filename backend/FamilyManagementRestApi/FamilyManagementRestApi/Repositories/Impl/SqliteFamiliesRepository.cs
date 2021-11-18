using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class SqliteFamiliesRepository : IFamiliesRepository
    {
        private FamilyDbContext _ctx;

        public SqliteFamiliesRepository(FamilyDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<Family>> GetFamiliesAsync()
        {
            return await _ctx.Families.ToListAsync();
        }

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            return await _ctx.Families.FirstOrDefaultAsync(f =>
                f.StreetName == streetName && f.HouseNumber == houseNumber);
        }

        public async Task<Family> UpdateFamilyAsync(Family family)
        {
            Family existingFamily = await _ctx.Families.FirstOrDefaultAsync(f =>
                f.StreetName == family.StreetName && f.HouseNumber == family.HouseNumber);
           _ctx.Entry(existingFamily).CurrentValues.SetValues(family);
           await _ctx.SaveChangesAsync(); 
           return family; 
        }

        public async Task<Family> DeleteFamilyAsync(string streetName, int houseNumber)
        {
            Family familyToBeDeleted = await GetFamilyAsync(streetName, houseNumber);
            _ctx.Families.Remove(familyToBeDeleted);
            await _ctx.SaveChangesAsync();
            return familyToBeDeleted; 
        }

        public async Task<Family> CreateFamilyAsync(Family family)
        {
            await _ctx.Families.AddAsync(family);
            await _ctx.SaveChangesAsync();
            return family; 
        }

        public bool FamilyExists(string streetName, int houseNumber)
        {
            Family existingFamily =
                _ctx.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            if (existingFamily == null)
            {
                return false; 
            }

            return true; 
        }
    }
}