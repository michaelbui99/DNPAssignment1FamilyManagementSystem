using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }

        public Family GetFamily(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFamily(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}