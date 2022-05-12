using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace spa_backend.Models
{
    public class RegisterRequest
    {
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;

        [Required]
        [JsonPropertyName("confirm_password")]
        [Compare(nameof(Password), ErrorMessage = "The password and confirm password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

    }
}
