namespace Bookify.DataAccess.Data.EntitiesConfig.identity
{
	public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.ToTable("Roles", schema: "UserManagement");

			builder.HasIndex(x=> x.Name).IsUnique();

			builder.HasData(LoadRoles());
		}

		private IEnumerable<AppRole> LoadRoles()
		{
			return new List<AppRole>()
			{
				new AppRole
				{
					Id = DefaultRole.AdminRoleId,
					Name = DefaultRole.Admin,
					IsDefault = false,
					ConcurrencyStamp = DefaultRole.AdminConcurrencyStamp,
					NormalizedName = DefaultRole.Admin.ToUpper()
				},
				new AppRole
				{
					Id = DefaultRole.MemberRoleId,
					Name = DefaultRole.Member,
					IsDefault = true,
					ConcurrencyStamp = DefaultRole.ManagerConcurrencyStamp,
					NormalizedName = DefaultRole.Member.ToUpper()
				},
			};
		}
	}
}
