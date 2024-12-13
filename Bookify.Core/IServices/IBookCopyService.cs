namespace Bookify.Core.IServices
{
	public interface IBookCopyService
	{
		Task<IList<BookCopyViewModel>> GetAllAsync();
		Task<BookCopyViewModel> GetByIdAsync(int id);
		Task<int> CreateAsync(CreateBookCopyViewModel model);
		Task<int> UpdateAsync(int id, CreateBookCopyViewModel model);
		Task DeleteAsync(int id);
        Task<int> Count();
    }
}
