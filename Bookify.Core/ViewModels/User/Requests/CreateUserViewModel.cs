namespace Bookify.Core.ViewModels.User.Requests
{
    public class CreateUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(RegexPatterns.NamePattern,ErrorMessage = Errors.ValidateName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(RegexPatterns.NamePattern, ErrorMessage = Errors.ValidateName)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = Errors.InvalidEmail)]
        [Remote(action: "AllowEmail",controller: "Users",ErrorMessage = Errors.EmailDublicated)]
        public string Email { get; set; } = null!;

        [Required,DataType(DataType.Password)]
        [RegularExpression(RegexPatterns.PasswordPattern,ErrorMessage = Errors.Password)]
        [StringLength(100, ErrorMessage = Errors.PasswordLength, MinimumLength = 8)]
        public string Password { get; set; } = null!;


        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = Errors.PasswordMatch)]
        public string ConfirmPassword { get; set; } = null!;

        public IList<string> SelectedRoles {  get; set; } = new List<string>(); // Admin can assign more than one Role for user during creation...
        public IEnumerable<SelectListItem>? Roles { get; set; }
    }
}
