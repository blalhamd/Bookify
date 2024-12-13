namespace Bookify.DataAccess.Data.EntitiesConfig.identity
{
	public class UserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
		{
			builder.ToTable("UserRoles", schema: "UserManagement");

			builder.HasData(LoadUserRoles());
		}

		private IEnumerable<IdentityUserRole<int>> LoadUserRoles()
		{
			return new List<IdentityUserRole<int>>()
			{
				new IdentityUserRole<int>()
				{
					RoleId = DefaultUser.AdminId,
					UserId = DefaultRole.AdminRoleId
				},
				new IdentityUserRole<int>()
				{
					RoleId = DefaultRole.MemberRoleId,
					UserId = DefaultRole.AdminRoleId
				},
			};
		}
	}
}
