namespace Bookify.Entities.entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Governorate : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Area> Areas { get; set; } = new List<Area>();
    }
}
