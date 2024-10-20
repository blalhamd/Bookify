namespace Bookify.Entities.entities
{
	public class Category : BaseEntity
	{
		public string Name { get; set; } = null!;
       // public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
