namespace Bookify.Entities.entities
{
	[Index(nameof(Name),nameof(GovernorateId),IsUnique = true)]
    public class Area : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int GovernorateId { get; set; }
        public Governorate? Governorate { get; set; } = null!;
    }
}
