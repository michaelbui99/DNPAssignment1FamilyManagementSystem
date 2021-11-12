using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManagementRestApi.Models
{
    public class Job
    {
        [Key, Column(Order = 0)]
        public string JobTitle { get; set; }
        [Key, Column(Order = 1)]
        public int Salary { get; set; }
    }
}