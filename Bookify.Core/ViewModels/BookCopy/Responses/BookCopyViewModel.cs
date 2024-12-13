namespace Bookify.Core.ViewModels.BookCopy.Responses
{
	public class BookCopyViewModel 
	{
        public string Id { get; set; }
        public int BookId { get; set; }
		public string Title { get; set; } = null!;
		public bool IsAvailableForRental { get; set; }
		public int EditionNumber { get; set; }
		public int SerialNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}
