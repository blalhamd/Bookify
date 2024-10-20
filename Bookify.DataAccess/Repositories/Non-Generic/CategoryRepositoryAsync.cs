using Bookify.Core.IRepositories.Non_Generic;
using Bookify.DataAccess.Data.Context;
using Bookify.DataAccess.Repositories.Generic;

namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
	{
		public CategoryRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
