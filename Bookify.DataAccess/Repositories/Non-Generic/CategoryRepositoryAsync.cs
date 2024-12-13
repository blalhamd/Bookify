
namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
	{
		private readonly AppDbContext _appDbContext;
		public CategoryRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
			_appDbContext = appDbContext;
		}


		public async Task<bool> IsCategoryExist(string name)
		{
			return await _appDbContext.Categories.AnyAsync(c => c.Name.ToLower() == name.ToLower());
		}
	}
}
