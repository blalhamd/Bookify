namespace Bookify.Entities.entities.Base
{
    public class BaseEntity : ICreationTime,IModification,IEntityCreatedByUser,ISoftDeletable
    {
        public int Id { get; set; }
		public DateTime CreationTime { get; set; } = DateTime.Now;
		public int? FirstModificationByUserId { get; set; }
		public int? LastModificationByUserId { get; set; }
		public DateTime? FirstModificationDate { get; set; }
		public DateTime? LastModificationDate { get; set; }
		public int CreatedByUserId { get; set; }
		public int? DeletedByUserId { get; set; }
		public DateTime? DeletionTime { get; set; }
		public bool IsDeleted { get; set; }
	}
}
