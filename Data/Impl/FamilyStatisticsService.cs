using System;
using System.Collections.Generic;
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

        public IDictionary<string, int> GetEyeColorDistribution()
        {
            HashSet<string> allEyeColors = GetAllEyeColors();
            Dictionary<string, int> eyeColorDistributionDataSet = new Dictionary<string, int>();
            IList<Family> families = _familyService.GetFamilies();

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

        public IDictionary<string, decimal> GetSalaryDistribution()
        {
            Dictionary<string, decimal> salaryDistributionDataSet = new Dictionary<string, decimal>();
            IList<Family> allFamilies = _familyService.GetFamilies();
            
            foreach (var family in allFamilies)
            {
                decimal familySalary = 0;
                family.Adults.ForEach(a => familySalary+= a.JobTitle.Salary);
                salaryDistributionDataSet.Add($"{family.StreetName} {family.HouseNumber}", familySalary);
            }
            
            return salaryDistributionDataSet;
        }

        public decimal GetAverageChildrenPerFamily()
        {
            return (decimal) GetTotalAmountOfChildren() / (decimal) GetTotalAmountOfFamilies();
        }

        public int GetTotalAmountOfFamilies()
        {
            int count = 0;
            IList<Family> families = _familyService.GetFamilies();
            foreach (var family in families)
            {
                count++;
            }

            return count;
        }

        public int GetTotalAmountOfAdults()
        {
            int count = 0;
            IList<Family> families = _familyService.GetFamilies();
            foreach (var family in families)
            {
                family.Adults.ForEach(a => count++);
            }

            return count;
        }

        public int GetTotalAmountOfChildren()
        {
            int count = 0;
            IList<Family> families = _familyService.GetFamilies();
            foreach (var family in families)
            {
                family.Children.ForEach(c => count++);
            }

            return count;
        }

        public int GetTotalAmountOfPets()
        {
            int count = 0;
            IList<Family> families = _familyService.GetFamilies();
            foreach (var family in families)
            {
                family.Pets.ForEach(p => count++);

                family.Children.ForEach(c => c.Pets.ForEach(p => count++));
            }

            return count;
        }

        public decimal GetAverageSalaryPerFamily()
        {
            decimal totalSalary = 0;
            IList<Family> families = _familyService.GetFamilies();
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

            return totalSalary / GetTotalAmountOfFamilies();
        }

        private HashSet<string> GetAllEyeColors()
        {
            HashSet<string> allEyeColors = new HashSet<string>();
            IList<Family> families = _familyService.GetFamilies();
            foreach (var family in families)
            {
                family.Adults.ForEach(a => allEyeColors.Add(a.EyeColor));
                family.Children.ForEach(c => allEyeColors.Add(c.EyeColor));
            }

            return allEyeColors;
        }
    }
}