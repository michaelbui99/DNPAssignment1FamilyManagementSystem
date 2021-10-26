using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNPAssignment1FamilyManagementSystem.Models;

namespace DNPAssignment1FamilyManagementSystem.Data.Impl
{
    public class FamilyStatisticsService : IFamilyStatisticsService
    {
        private IFamilyService _familyService;

        public FamilyStatisticsService(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public async Task<IDictionary<string, int>> GetEyeColorDistributionAsync()
        {
            HashSet<string> allEyeColors = await GetAllEyeColors();
            Dictionary<string, int> eyeColorDistributionDataSet = new Dictionary<string, int>();
            IList<Family> families = await _familyService.GetFamiliesAsync();

            foreach (var eyeColor in allEyeColors)
            {
                int colorOccurence = 0;
                foreach (var family in families)
                {
                    family.Adults.ForEach(a =>
                    {
                        if (a.EyeColor == eyeColor)
                        {
                            colorOccurence++;
                        }
                    });
                    family.Children.ForEach(c =>
                    {
                        if (c.EyeColor == eyeColor)
                        {
                            colorOccurence++;
                        }
                    });
                }

                eyeColorDistributionDataSet.Add(eyeColor, colorOccurence);
            }

            return eyeColorDistributionDataSet;
        }

        public async Task<IDictionary<string, decimal>> GetSalaryDistributionAsync()
        {
            Dictionary<string, decimal> salaryDistributionDataSet = new Dictionary<string, decimal>();
            IList<Family> allFamilies = await _familyService.GetFamiliesAsync();
            
            foreach (var family in allFamilies)
            {
                decimal familySalary = 0;
                family.Adults.ForEach(a => familySalary+= a.JobTitle.Salary);
                salaryDistributionDataSet.Add($"{family.StreetName} {family.HouseNumber}", familySalary);
            }
            
            return salaryDistributionDataSet;
        }

        public async Task<decimal> GetAverageChildrenPerFamilyAsync()
        {
            return  (decimal) await GetTotalAmountOfChildrenAsync() / (decimal) await GetTotalAmountOfFamiliesAsync();
        }

        public async Task<int> GetTotalAmountOfFamiliesAsync()
        {
            int count = 0;
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                count++;
            }

            return count;
        }

        public async Task<int> GetTotalAmountOfAdultsAsync()
        {
            int count = 0;
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                family.Adults.ForEach(a => count++);
            }

            return count;
        }

        public async Task<int> GetTotalAmountOfChildrenAsync()
        {
            int count = 0;
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                family.Children.ForEach(c => count++);
            }

            return count;
        }

        public async Task<int> GetTotalAmountOfPetsAsync()
        {
            int count = 0;
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                family.Pets.ForEach(p => count++);

                family.Children.ForEach(c => c.Pets.ForEach(p => count++));
            }

            return count;
        }

        public async Task<decimal> GetAverageSalaryPerFamilyAsync()
        {
            decimal totalSalary = 0;
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                family.Adults.ForEach(a =>
                {
                    if (a.JobTitle != null)
                    {
                        totalSalary += a.JobTitle.Salary;
                    }
                });
            }

            return totalSalary / await GetTotalAmountOfFamiliesAsync();
        }

        private async Task<HashSet<string>> GetAllEyeColors()
        {
            HashSet<string> allEyeColors = new HashSet<string>();
            IList<Family> families = await _familyService.GetFamiliesAsync();
            foreach (var family in families)
            {
                family.Adults.ForEach(a => allEyeColors.Add(a.EyeColor));
                family.Children.ForEach(c => allEyeColors.Add(c.EyeColor));
            }

            return allEyeColors;
        }
    }
}