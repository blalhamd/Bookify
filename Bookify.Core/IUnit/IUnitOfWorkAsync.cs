namespace Bookify.Core.IUnit
{
	public interface IUnitOfWorkAsync : IAsyncDisposable
	{
		ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }
		IAuthorRepositoryAsync _AuthorRepositoryAsync { get; }
		IBookRepositoryAsync _BookRepositoryAsync { get; }
		IBookCopyRepositoryAsync _BookCopyRepositoryAsync { get; }
        ISubscriberRepositoryAsync _SubscriberRepositoryAsync { get; }
		IGenericRepositoryAsync<BaseEntity> _GenericRepositoryAsync { get; }
		Task<int> Save();
	}
}
