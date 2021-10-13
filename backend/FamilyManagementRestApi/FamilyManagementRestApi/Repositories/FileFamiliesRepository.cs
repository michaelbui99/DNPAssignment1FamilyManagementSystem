using System;
using System.Collections.Generic;
using System.Linq;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;

namespace FamilyManagementRestApi.Repositories
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

        public Family GetFamily(string streetName, int houseNumber)
        {
            Family familyToReturn =
                _fileContext.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            if (familyToReturn == null)
            {
                throw new Exception("No such family exists");
            }

            return familyToReturn;
        }

        public void UpdateFamily(Family family)
        {
            if (FamilyExists(family.StreetName, family.HouseNumber))
            {
                int indexOfFamily = _fileContext.Families.ToList()
                    .FindIndex(existingFamily => existingFamily.Id == family.Id);
                _fileContext.Families[indexOfFamily] = family;
                _fileContext.SaveChanges();
            }
            else
            {
                _fileContext.Families.Add(family);
                _fileContext.SaveChanges();
            }
        }

        public void DeleteFamily(string streetName, int houseNumber)
        {
            if (!FamilyExists(streetName, houseNumber))
            {
                throw new Exception("No such family exists");
            }

            int indexOfFamily = _fileContext.Families.ToList()
                .FindIndex(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            _fileContext.Families.RemoveAt(indexOfFamily);
            _fileContext.SaveChanges();
        }

        public void CreateFamily(Family family)
        {
            throw new NotImplementedException();
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