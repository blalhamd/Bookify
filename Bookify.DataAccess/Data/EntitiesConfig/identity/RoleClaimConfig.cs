namespace Bookify.DataAccess.Data.EntitiesConfig.identity
{
	public class RoleClaimConfig : IEntityTypeConfiguration<IdentityRoleClaim<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityRoleClaim<int>> builder)
		{
			builder.ToTable("RoleClaims", schema: "UserManagement");

			builder.HasData(LoadRoleClaim());
		}

		private IEnumerable<IdentityRoleClaim<int>> LoadRoleClaim()
		{
			var AdminClaims = new List<IdentityRoleClaim<int>>();
			var count = 1;

			foreach (var item in Permissions.GetPermissions())
			{
				AdminClaims.Add(new IdentityRoleClaim<int>
				{
					Id = count++,
					RoleId = DefaultRole.AdminRoleId,
					ClaimType = Permissions.Type,
					ClaimValue = item
				});
			}

			return AdminClaims;
		}

	}
}
