namespace Bookify.DataAccess.Data.EntitiesConfig.identity
{
	public class AppUserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.ToTable("Users", schema: "UserManagement");

			builder.HasIndex(x=> x.Email).IsUnique();
			builder.HasIndex(x=> x.UserName).IsUnique();

			builder.HasData(LoadUser());
		}

		private AppUser LoadUser()
		{
			var hasher = new PasswordHasher<AppUser>();

			return new AppUser
			{
				Id = DefaultUser.AdminId,
				FirstName = DefaultUser.AdminFirstName,
				LastName = DefaultUser.AdminLastName,
				Email = DefaultUser.AdminEmail,
				NormalizedEmail = DefaultUser.AdminEmail.ToUpper(),
				UserName = DefaultUser.AdminEmail.Split('@').First(),
				NormalizedUserName = DefaultUser.AdminEmail.Split('@').First().ToUpper(),
				PasswordHash = hasher.HashPassword(null!, DefaultUser.AdminPassword),
				ConcurrencyStamp = DefaultUser.ConcurrencyStamp,
				SecurityStamp = DefaultUser.SecurityStamp,
				EmailConfirmed = true // because this admin
			};
		}
	}
}
