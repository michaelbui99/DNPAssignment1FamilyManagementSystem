using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Models
{
    public class User
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required"), Range(8, int.MaxValue, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}