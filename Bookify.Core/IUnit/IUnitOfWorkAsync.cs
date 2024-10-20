namespace Bookify.Core.IUnit
{
	public interface IUnitOfWorkAsync : IAsyncDisposable
	{
		ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }
		IAuthorRepositoryAsync _AuthorRepositoryAsync { get; }
		IBookRepositoryAsync _BookRepositoryAsync { get; }
		Task<int> Save();
	}
}
