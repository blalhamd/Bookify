namespace Bookify.Core.IServices
{
	public interface IBookService
	{
		Task<IList<BookViewModel>> GetAllAsync();
		Task<BookViewModel> GetByIdAsync(int id);
		Task CreateAsync(CreateBookViewModel model);
		Task UpdateAsync(int id, CreateBookViewModel model);
		Task DeleteAsync(int id);
		Task<IList<BookViewModel>?> GetLastEightBooks();
		Task<IList<BookSearchResult>> FindAsync(string searchTerm);
	}
}
