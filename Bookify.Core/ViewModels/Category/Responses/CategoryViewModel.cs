namespace Bookify.Core.ViewModels.Category.Responses
{
	public class CategoryViewModel
	{
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}
