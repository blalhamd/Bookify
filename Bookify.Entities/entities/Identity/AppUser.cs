namespace Bookify.Entities.entities.Identity
{
	public class AppUser : IdentityUser<int>
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.Now;
	}
}
