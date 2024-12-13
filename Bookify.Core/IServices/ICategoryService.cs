namespace Bookify.Core.IServices
{
	public interface ICategoryService
	{
		Task<IList<CategoryViewModel>> GetAllAsync();
		Task<CategoryViewModel> GetByIdAsync(int id);
		Task<int> CreateAsync(CreateCategoryRequest model);
        Task<int> UpdateAsync(int id, CreateCategoryRequest model);
		Task DeleteAsync(int id);
		Task<bool> IsExist(string Name);
	}
}
