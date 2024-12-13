namespace Bookify.Entities.entities.Identity
{
	public class AppRole : IdentityRole<int>
	{
		public bool IsDefault { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
	}
}
