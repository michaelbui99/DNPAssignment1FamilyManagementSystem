using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyManagementRestApi.Models;
using FamilyManagementRestApi.Persistence;

namespace FamilyManagementRestApi.Repositories.Impl
{
    public class FileAdultRepository : IAdultsRepository
    {
        private IFamiliesRepository _familiesRepository;
        private FileContext _fileContext;


        public FileAdultRepository(IFamiliesRepository familiesRepository, FileContext fileContext)
        {
            _familiesRepository = familiesRepository;
            _fileContext = fileContext;
        }

        public async Task<IEnumerable<Adult>> GetAdultsAsync()
        {
            IList<Adult> allAdults = new List<Adult>();
            var families = await _familiesRepository.GetFamiliesAsync(); 
            foreach (var family in families)
            {
                family.Adults.ForEach(a => allAdults.Add(a));
            }

            return allAdults;
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            Adult adultToReturn = null;
            foreach (var family in _fileContext.Families)
            {
                family.Adults.ForEach(a =>
                {
                    if (a.Id == id)
                    {
                        adultToReturn = a;
                    }
                });
            }

            if (adultToReturn == null)
            {
                throw new KeyNotFoundException("No such adult exists"); 
            }

            return adultToReturn; 

        }


        public async Task<Adult> AddAdultToFamilyAsync(Family family, Adult adult)
        {
            if (!_familiesRepository.FamilyExists(family.StreetName, family.HouseNumber))
            {
                throw new KeyNotFoundException("No such family exists"); 
            }
            if (family == null || adult == null)
            {
                throw new NullReferenceException("Arguments must not be null");
            }

            int indexOfFamily = _fileContext.Families.IndexOf(family);
            int maxId = 0; 
            foreach (var f in _fileContext.Families)
            {
                int maxIdOfCurrentFamily = f.Adults.Max(a => a.Id);
                if (maxIdOfCurrentFamily >= maxId)
                {
                    maxId = maxIdOfCurrentFamily;
                }
            }

            adult.Id = maxId+1;
            _fileContext.Families[indexOfFamily].Adults.Add(adult);
            _fileContext.SaveChanges();
            return adult;
        }

        public async Task<Adult> RemoveAdultFromFamilyAsync(Family family, Adult adult)
        {
            if (!_familiesRepository.FamilyExists(family.StreetName, family.HouseNumber))
            {
                throw new KeyNotFoundException("No such family exists"); 
            }

            if (family == null || adult == null)
            {
                throw new NullReferenceException("Arguments must not be null"); 
            }
            
            int indexOfFamily = _fileContext.Families.IndexOf(family);
            int indexOfAdult = _fileContext.Families[indexOfFamily].Adults.IndexOf(adult);
            Adult removedAdult = _fileContext.Families[indexOfAdult].Adults[indexOfAdult];
            _fileContext.Families[indexOfAdult].Adults.RemoveAt(indexOfAdult);
            _fileContext.SaveChanges();
            return removedAdult;
        }
    }
}