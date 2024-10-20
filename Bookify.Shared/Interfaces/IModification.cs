namespace Bookify.Shared.Interfaces
{
	public interface IModification
	{
		int? FirstModificationByUserId { get; set; }
		int? LastModificationByUserId { get; set; }
		DateTime? FirstModificationDate { get; set; }
	    DateTime? LastModificationDate { get; set; }
	}
}
