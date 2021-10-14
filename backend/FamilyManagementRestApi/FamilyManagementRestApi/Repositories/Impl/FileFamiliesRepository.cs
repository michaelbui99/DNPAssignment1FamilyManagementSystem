using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class FileFamiliesRepository : IFamiliesRepository
    {
        private FileContext _fileContext;

        public FileFamiliesRepository(FileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public IEnumerable<Family> GetFamilies()
        {
            return _fileContext.Families;
        }

        public async Task<IEnumerable<Family>> GetFamiliesAsync()
        {
            return _fileContext.Families; 
        }

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            Family familyToReturn =
                _fileContext.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            if (familyToReturn == null)
            {
                throw new KeyNotFoundException("No such family exists");
            }

            return familyToReturn;
        }

        public async Task<Family> UpdateFamilyAsync(Family family)
        {
            if (FamilyExists(family.StreetName, family.HouseNumber))
            {
                int indexOfFamily = _fileContext.Families.ToList()
                    .FindIndex(existingFamily => existingFamily.Id == family.Id);
                _fileContext.Families[indexOfFamily] = family;
                _fileContext.SaveChanges();
                return family; 
            }
            else
            {
                throw new KeyNotFoundException("No such family exists"); 
            }
        }

        public async Task<Family> DeleteFamilyAsync(string streetName, int houseNumber)
        {
            if (!FamilyExists(streetName, houseNumber))
            {
                throw new KeyNotFoundException("No such family exists");
            }

            int indexOfFamily = _fileContext.Families.ToList()
                .FindIndex(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            Family deletedFamily = _fileContext.Families[indexOfFamily];
            _fileContext.Families.RemoveAt(indexOfFamily);
            _fileContext.SaveChanges();
            return deletedFamily;
        }

        public async Task<Family> CreateFamilyAsync(Family family)
        {
            if (FamilyExists(family.StreetName, family.HouseNumber))
            {
                throw new ArgumentException("Family already exists");
            }
            
            _fileContext.Families.Add(family);
            _fileContext.SaveChanges();
            return family; 
        }

        private bool FamilyExists(string streetName, int houseNumber)
        {
            Family existingFamily =
                _fileContext.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            if (existingFamily == null)
            {
                return false;
            }

            return true;
        }
    }
}