namespace Bookify.Core.ViewModels.Category.Requests
{
	public class CreateCategoryRequest 
	{
		[Required,Display(Name = "Category")]
		[MaxLength(length: 100, ErrorMessage = Errors.MaxLength)]
		public string Name { get; set; } = null!;
	}
}
