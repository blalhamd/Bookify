namespace Bookify.Shared.Interfaces
{
	public interface ISoftDeletable
	{
		int? DeletedByUserId { get; set; }
		DateTime? DeletionTime { get; set; }
		bool IsDeleted { get; set; }
	}
}
