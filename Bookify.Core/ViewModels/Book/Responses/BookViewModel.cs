namespace Bookify.Core.ViewModels.Book.Responses
{
	public class BookViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string Type { get; set; } = null!;
		public DateTime PublishedOn { get; set; }
		public string Publisher { get; set; } = null!;
		public string? ImageUrl { get; set; }
		public string Hall { get; set; } = null!;
		public bool IsAvailableForRental { get; set; } = false;
		public decimal Price { get; set; }
		public int AuthorId { get; set; }
		
	}
}
