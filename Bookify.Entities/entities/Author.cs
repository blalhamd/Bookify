namespace Bookify.Entities.entities
{
	public class Author : BaseEntity
	{
		public string Name { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
