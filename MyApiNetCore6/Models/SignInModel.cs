using System.ComponentModel.DataAnnotations;

namespace MyApiNetCore6.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "Password is requied")]
        public string Password { get; set; } = null!;
    }
}
