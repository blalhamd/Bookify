using Bookify.Core.IRepositories.Non_Generic;

namespace Bookify.Core.IUnit
{
	public interface IUnitOfWorkAsync : IAsyncDisposable
	{
		ICategoryRepositoryAsync _CategoryRepositoryAsync { get; }
		Task<int> Save();
	}
}
