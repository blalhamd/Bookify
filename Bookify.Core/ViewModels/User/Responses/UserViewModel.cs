namespace Bookify.Core.ViewModels.User.Responses
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsDeleted { get; set; } 
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public IList<string> SelectedRoles { get; set; } = new List<string>();
        public IEnumerable<SelectListItem>? Roles { get; set; }
    }
}
