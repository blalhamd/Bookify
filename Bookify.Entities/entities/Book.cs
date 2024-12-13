namespace Bookify.Entities.entities
{
	public class Book : BaseEntity
	{
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public BookType Type { get; set; }
        public DateTime PublishedOn { get; set; }
		public string Publisher { get; set; } = null!;
        public string? ImageUrl { get; set; }
		public string Hall { get; set; } = null!;
        public bool IsAvailableForRental { get; set; } = false;
        public decimal Price { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; } = null!;
        public ICollection<BookCategory> Categories { get; set; } = new List<BookCategory>();
        public ICollection<BookCopy> Copies { get; set; } = new List<BookCopy>();
    }
}
