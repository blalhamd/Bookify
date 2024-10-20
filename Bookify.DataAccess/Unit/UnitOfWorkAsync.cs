using Bookify.Core.IRepositories.Non_Generic;
using Bookify.Core.IUnit;
using Bookify.DataAccess.Data.Context;
using Bookify.DataAccess.Repositories.Non_Generic;

namespace Bookify.DataAccess.Unit
{
	public class UnitOfWorkAsync : IUnitOfWorkAsync
	{
		public ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }
		private readonly AppDbContext _appDbContext;
		public UnitOfWorkAsync(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
			_CategoryRepositoryAsync = new CategoryRepositoryAsync(appDbContext);
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
