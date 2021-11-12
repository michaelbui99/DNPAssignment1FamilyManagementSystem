using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FamilyManagementRestApi.Models
{
    public class Interest
    {
        [Key] public string Type { get; set; }
        public string Description { get; set; }
        public List<Child> Children { get; set; }
    }
}