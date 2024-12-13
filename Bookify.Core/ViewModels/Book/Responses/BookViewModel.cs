namespace Bookify.Core.ViewModels.Book.Responses
{
    public class BookViewModel
	{
		public string Id { get; set; } = null!;
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string Type { get; set; } = null!;
		public DateTime PublishedOn { get; set; }
		public string Publisher { get; set; } = null!;
		public string? ImageUrl { get; set; }
		public string Hall { get; set; } = null!;
		public bool IsAvailableForRental { get; set; } = false;
		public decimal Price { get; set; }
		public string AuthorName { get; set; } = null!;
		public IEnumerable<SelectListItem>? Authors { get; set; } 
        public IList<string> SelectedCategories { get; set; } = new List<string>();
        public IEnumerable<SelectListItem>? CategoriesList { get; set; }
		public IEnumerable<BookCopyViewModel> BookCopies { get; set; } = new List<BookCopyViewModel>();
    }
}
