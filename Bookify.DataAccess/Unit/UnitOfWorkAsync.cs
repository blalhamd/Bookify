namespace Bookify.DataAccess.Unit
{
	public class UnitOfWorkAsync : IUnitOfWorkAsync
	{
		public ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }

		public IAuthorRepositoryAsync _AuthorRepositoryAsync {  get; }

		public IBookRepositoryAsync _BookRepositoryAsync { get; }

		private readonly AppDbContext _appDbContext;
		public UnitOfWorkAsync(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
			_CategoryRepositoryAsync = new CategoryRepositoryAsync(appDbContext);
			_AuthorRepositoryAsync = new AuthorRepositoryAsync(appDbContext);
			_BookRepositoryAsync = new BookRepositoryAsync(appDbContext);
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
