using System;
using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace DNPAssignment1FamilyManagementSystem.Data
{
    public class FileFamilyService : IFamilyService
    {
        private FileContext _fileContext;

        public FileFamilyService(FileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public IList<Family> GetFamilies()
        {
            IList<Family> families = _fileContext.Families;
            if (families.Count == 0)
            {
                throw new Exception("No Families found"); 
            }

            return families; 
        }

        public void CreateFamily(Family family)
        {
            
            foreach (var f in _fileContext.Families)
            {
                if (f.StreetName == family.StreetName && f.HouseNumber == family.HouseNumber)
                {
                    throw new Exception("Family already exists"); 
                }
            }
            
            _fileContext.Families.Add(family);
            _fileContext.SaveChanges();
        }

        public void DeleteFamily(string streetName, int houseNumber)
        {
            Family familyToRemove =
                _fileContext.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
            if (familyToRemove is null)
            {
                throw new Exception("No such family exist"); 
            }

            _fileContext.Families.Remove(familyToRemove); 
            _fileContext.SaveChanges();
        }

        public Family Get(string streetName, int houseNumber)
        {
            Family familyToReturn = _fileContext.Families.FirstOrDefault(f => f.StreetName
                == streetName && f.HouseNumber == houseNumber);
            if (familyToReturn is null)
            {
                throw new Exception("Family not found"); 
            }

            return familyToReturn; 
        }
    }
}