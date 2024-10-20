namespace Bookify.Core.ViewModels.Author.Requests
{
	public class CreateAuthorViewModel
	{
        [Required, Display(Name = "Author"), MaxLength(100, ErrorMessage = Errors.MaxLength)]
        public string Name { get; set; } = null!;
		
		[Required, MaxLength(100, ErrorMessage = Errors.MaxLength)]
		public string Nationality { get; set; } = null!;
	}
}
