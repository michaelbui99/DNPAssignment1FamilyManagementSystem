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