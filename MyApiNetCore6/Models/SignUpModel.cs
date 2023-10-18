using System.ComponentModel.DataAnnotations;

namespace MyApiNetCore6.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = null!;
        [Required, EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Comfirm is required")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
