using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace spa_backend.Models
{
    public class LoginRequest
    {
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
    }
}
