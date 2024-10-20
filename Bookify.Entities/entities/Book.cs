namespace Bookify.Entities.entities
{
	public class Book : BaseEntity
	{
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public BookType Type { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
		public Author Author { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
