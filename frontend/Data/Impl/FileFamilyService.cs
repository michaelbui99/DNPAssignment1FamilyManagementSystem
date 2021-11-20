// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using DNPAssignment1FamilyManagementSystem.Models;
// using DNPAssignment1FamilyManagementSystem.Persistence;
//
// namespace DNPAssignment1FamilyManagementSystem.Data.Impl
// {
//     public class FileFamilyService : IFamilyService
//     {
//         private FileContext _fileContext;
//
//         public FileFamilyService(FileContext fileContext)
//         {
//             _fileContext = fileContext;
//         }
//
//         public async Task<IList<Family>> GetFamiliesAsync()
//         {
//             IList<Family> families = _fileContext.Families;
//             if (families.Count == 0)
//             {
//                 throw new Exception("No Families found");
//             }
//
//             return  families;
//         }
//
//         public async Task CreateFamilyAsync(Family family)
//         {
//             foreach (var f in _fileContext.Families)
//             {
//                 if (f.StreetName == family.StreetName && f.HouseNumber == family.HouseNumber)
//                 {
//                     throw new Exception("Family already exists");
//                 }
//             }
//
//             _fileContext.Families.Add(family);
//             _fileContext.SaveChanges();
//         }
//
//         public async Task DeleteFamilyAsync(string streetName, int houseNumber)
//         {
//             Family familyToRemove =
//                 _fileContext.Families.FirstOrDefault(f => f.StreetName == streetName && f.HouseNumber == houseNumber);
//             if (familyToRemove is null)
//             {
//                 throw new Exception("No such family exist");
//             }
//
//             _fileContext.Families.Remove(familyToRemove);
//             _fileContext.SaveChanges();
//         }
//
//         public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
//         {
//             Family familyToReturn = _fileContext.Families.FirstOrDefault(f => f.StreetName
//                 == streetName && f.HouseNumber == houseNumber);
//             if (familyToReturn is null)
//             {
//                 throw new Exception("Family not found");
//             }
//
//             return familyToReturn;
//         }
//
//         public async Task AddAdultToFamilyAsync(Family family, Adult adult)
//         {
//             if (family.Adults.Count >= 2)
//             {
//                 throw new Exception("Family cannot exceed 2 adults");
//             }
//
//             CheckFamilyExists(family);
//
//             int indexOfFamily = _fileContext.Families.IndexOf(family);
//             var maxIdOfAllAdults = GetMaxIdOfAllAdults();
//             adult.Id = maxIdOfAllAdults;
//             _fileContext.Families[indexOfFamily].Adults.Add(adult);
//             _fileContext.SaveChanges();
//         }
//
//
//         private int GetMaxIdOfAllAdults()
//         {
//             int maxIdOfAllAdults = 0;
//             foreach (var family in _fileContext.Families)
//             {
//                 if (family.Adults.Any())
//                 {
//                     int maxIdOfCurrentFamily = family.Adults.Max(a => a.Id);
//                     if (maxIdOfCurrentFamily > maxIdOfAllAdults)
//                     {
//                         maxIdOfAllAdults = maxIdOfCurrentFamily;
//                     }
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }
//
//             return maxIdOfAllAdults;
//         }
//
//         public async Task RemoveAdultFromFamilyAsync(Family family, Adult adult)
//         {
//             CheckFamilyExists(family);
//
//             int indexOfFamily = _fileContext.Families.IndexOf(family);
//             if (_fileContext.Families[indexOfFamily].Adults.Contains(adult))
//             {
//                 _fileContext.Families[indexOfFamily].Adults.Remove(adult);
//                 _fileContext.SaveChanges();
//             }
//             else
//             {
//                 throw new Exception("Adult does not exist in the family");
//             }
//         }
//
//         public async Task RemoveChildFromFamilyAsync(Family family, Child child)
//         {
//             CheckFamilyExists(family);
//
//             int indexOfFamily = _fileContext.Families.IndexOf(family);
//             if (_fileContext.Families[indexOfFamily].Children.Contains(child))
//             {
//                 _fileContext.Families[indexOfFamily].Children.Remove(child); 
//                 _fileContext.SaveChanges();
//             }
//         }
//
//         private void CheckFamilyExists(Family family)
//         {
//             if (!_fileContext.Families
//                 .Where(f => f.StreetName == family.StreetName && f.HouseNumber == family.HouseNumber).ToList().Any())
//             {
//                 throw new Exception("No such family exists");
//             }
//         }
//     }
// }