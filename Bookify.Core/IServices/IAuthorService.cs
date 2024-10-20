namespace Bookify.Core.IServices
{
	public interface IAuthorService
	{
		Task<IList<AuthorViewModel>> GetAllAsync();
		Task<AuthorViewModel> GetByIdAsync(int id);
		Task CreateAsync(CreateAuthorViewModel model);
		Task UpdateAsync(int id, CreateAuthorViewModel model);
		Task DeleteAsync(int id);
	}
}
