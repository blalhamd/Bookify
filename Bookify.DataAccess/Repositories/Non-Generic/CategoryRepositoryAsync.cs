namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
	{
		public CategoryRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
