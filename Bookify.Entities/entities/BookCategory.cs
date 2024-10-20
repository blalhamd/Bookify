namespace Bookify.Entities.entities
{
	public class BookCategory
	{
		public int CategoryId { get; set; }
        public int BookId { get; set; }
        public Category Category { get; set; } = null!;
        public Book Book { get; set; } = null!;
	}
}
