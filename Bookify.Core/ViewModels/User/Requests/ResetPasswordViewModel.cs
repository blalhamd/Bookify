namespace Bookify.Core.ViewModels.User.Requests
{
    public class ResetPasswordViewModel
    {
        public int Id { get; set; }

        [Required, DataType(DataType.Password)]
        [RegularExpression(RegexPatterns.PasswordPattern, ErrorMessage = Errors.Password)]
        [StringLength(100, ErrorMessage = Errors.PasswordLength, MinimumLength = 8)]
        public string Password { get; set; } = null!;


        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = Errors.PasswordMatch)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
