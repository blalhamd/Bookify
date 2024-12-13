namespace Bookify.Core.ViewModels.BookCopy.Requests
{
	public class CreateBookCopyViewModel
	{
        public int BookId { get; set; }
		public bool IsAvailableForRental { get; set; }
		public int EditionNumber { get; set; }
        public bool ShowForRental { get; set; }
    }
}
