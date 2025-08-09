using System.ComponentModel.DataAnnotations;

namespace Model.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required")]
    public string? UserName { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Your Password is required")]
    public string? Password { get; set; }
}