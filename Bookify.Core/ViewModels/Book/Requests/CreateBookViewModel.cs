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
		public DateTime PublishedOn { get; set; } = DateTime.Now;

		[Required]
		public string Publisher { get; set; } = null!;

		[Required]

		public IFormFile? ImageUrl { get; set; }

		[Required]
		public string Hall { get; set; } = null!;

		[Required]
		public bool IsAvailableForRental { get; set; } 

		[Required]
		public decimal Price { get; set; }

		[Required]
		[Range(1,int.MaxValue,ErrorMessage = "Must Select Author")]
		public int AuthorId { get; set; }
        public IEnumerable<SelectListItem>? Authors { get; set; }
        [Required]
		public IList<int> SelectedCategories { get; set; } = new List<int>();
		public IEnumerable<SelectListItem>? Categories {  get; set; } 
	}
}
