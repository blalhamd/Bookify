using Bookify.Core.ViewModels.Category.Requests;
using Bookify.Core.ViewModels.Category.Responses;

namespace Bookify.Core.IServices
{
	public interface ICategoryService
	{
		Task<IList<CategoryViewModel>> GetAllAsync();
		Task<CategoryViewModel> GetByIdAsync(int id);
		Task CreateAsync(CreateCategoryRequest model);
		Task UpdateAsync(int id, CreateCategoryRequest model);
		Task DeleteAsync(int id);
	}
}
