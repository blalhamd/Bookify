namespace Bookify.DataAccess.Unit
{
	public class UnitOfWorkAsync : IUnitOfWorkAsync
	{
		public ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }

		public IAuthorRepositoryAsync _AuthorRepositoryAsync {  get; }

		public IBookRepositoryAsync _BookRepositoryAsync { get; }
		public IBookCopyRepositoryAsync _BookCopyRepositoryAsync { get; }
		public IGenericRepositoryAsync<BaseEntity> _GenericRepositoryAsync { get; }

        public ISubscriberRepositoryAsync _SubscriberRepositoryAsync { get; }

        private readonly AppDbContext _appDbContext;
		public UnitOfWorkAsync(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
			_CategoryRepositoryAsync = new CategoryRepositoryAsync(appDbContext);
			_AuthorRepositoryAsync = new AuthorRepositoryAsync(appDbContext);
			_BookRepositoryAsync = new BookRepositoryAsync(appDbContext);
			_BookCopyRepositoryAsync = new BookCopyRepositoryAsync(appDbContext);
            _SubscriberRepositoryAsync = new SubscriberRepositoryAsync(appDbContext);
			_GenericRepositoryAsync = new GenericRepositoryAsync<BaseEntity>(appDbContext);
		}

		public async ValueTask DisposeAsync()
		{
			await _appDbContext.DisposeAsync();
		}

		public async Task<int> Save()
		{
			return await _appDbContext.SaveChangesAsync();
		}
	}
}
