namespace Bookify.Core.constants
{
    public static class Errors
	{
		public const string MaxLength = "Max length is {1} characters.";
		public const string Dublicated = "{0} is Duplicated";
		public const string Existed = "Category is Already Existed";
		public const string InvalidEmail = "Email is Invalid";
		public const string EmailDublicated = "Email is already in use.";
        public const string Password = "Password must have At least one upper case[A-Z],lower case[a-z],special letters [$%^#],etc.";
		public const string PasswordLength = "The {0} must be at least {2} and at max {1} characters long.";
		public const string PasswordMatch = "The password and confirmation password do not match.";
		public const string ValidateName = "Name must be letters only.";
		public const string Area = "must select Area.";
		public const string Governorate = "must select Governorate.";
    }
}
