namespace Bookify.Core.ViewModels.Book.Requests
{
	public class CreateBookViewModel
	{
        [Required, MaxLength(100, ErrorMessage = Errors.MaxLength)]
		public string Title { get; set; } = null!;

		[Required]
		public string Description { get; set; } = null!;

		[Required]
		public string Type { get; set; } = null!;

		[Required]
		public DateTime PublishedOn { get; set; }

		[Required]
		public string Publisher { get; set; } = null!;

		[Required]
		public string? ImageUrl { get; set; }

		[Required]
		public string Hall { get; set; } = null!;

		[Required]
		public bool IsAvailableForRental { get; set; } 

		[Required]
		public decimal Price { get; set; }

		[Required]
		public int AuthorId { get; set; }

	}
}
