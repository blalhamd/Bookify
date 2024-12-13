namespace Bookify.Core.constants
{
    public static class RegexPatterns
	{
        public const string PasswordPattern = "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
        public const string NamePattern = "^[a-zA-Z_ ]*$";
    }
}
