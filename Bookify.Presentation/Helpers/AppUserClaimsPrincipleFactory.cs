namespace Bookify.Presentation.Helpers
{
    // don't forget to inject it in container services --> builder.Services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, AppUserClaimsPrincipleFactory>();
    public class AppUserClaimsPrincipleFactory : UserClaimsPrincipalFactory<AppUser,AppRole>
    {
        public AppUserClaimsPrincipleFactory(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim(ClaimTypes.GivenName, string.Join(' ', [user.FirstName, user.LastName])));

            return identity;
        }
    }
}
