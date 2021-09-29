using System.Text.Json;

namespace Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}