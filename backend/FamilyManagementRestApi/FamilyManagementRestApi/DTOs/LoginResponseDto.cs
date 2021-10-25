using System.Collections.Generic;
using FamilyManagementRestApi.Models;

namespace FamilyManagementRestApi.DTOs
{
    public class LoginResponseDto
    {
        public User User { get; set; }
        public string ErrorMessage { get; set; }
    }
}