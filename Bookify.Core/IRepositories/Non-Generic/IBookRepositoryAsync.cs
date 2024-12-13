namespace Bookify.Core.IRepositories.Non_Generic
{
	public interface IBookRepositoryAsync : IGenericRepositoryAsync<Book>
	{
        Task<IList<Book>> GetLastEightBooks();
		Task<IList<BookSearchResult>> FindAsync(string searchTerm);
	}
}
