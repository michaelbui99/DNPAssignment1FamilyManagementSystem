﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DNPAssignment1FamilyManagementSystem.Models
{
    public class User
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(Int32.MaxValue, MinimumLength = 8, ErrorMessage = "Password must be min. 8 characters")]
        public string Password { get; set; }
        public string Role { get; set; } = "User"; 
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}