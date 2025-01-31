﻿using System.ComponentModel.DataAnnotations;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.DTOs
{
    public class AddAdultDto
    {
        [Required] public string FamilyStreetName { get; set; }
        [Required ]public int FamilyHouseNumber { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }

        [Required] public string HairColor { get; set; }

        [Required] public string EyeColor { get; set; }

        [Required] public int Age { get; set; }
        [Required] public float Weight { get; set; }

        [Required] public int Height { get; set; }

        [Required] public string Sex { get; set; }

        public Job Job { get; set; }
    }
}