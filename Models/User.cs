using System.ComponentModel.DataAnnotations;

namespace EventEaseAppNew.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password must be 6-12 characters")]
        public string Password { get; set; } = string.Empty;
    }
}
