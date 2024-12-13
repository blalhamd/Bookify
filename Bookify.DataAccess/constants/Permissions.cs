namespace Bookify.DataAccess.constants
{
	public static class Permissions
	{
		public static string Type { get; } = "permissions";

		public const string GetAllRoles = "Roles:GetAll";
		public const string AddRole = "Roles:Add";
		public const string UpdateRole = "Roles:Update";
		public const string DeleteRole = "Roles:Delete";

		public const string GetAllUsers = "Users:GetAll";
		public const string AddUser = "Users:Add";
		public const string UpdateUser = "Users:Update";
		public const string DeleteUser = "Users:Delete";

		public static IList<string?> GetPermissions()
		{
			return typeof(Permissions).GetFields().Select(f=> f.GetValue(f) as string).ToList();
		}
    }
}

