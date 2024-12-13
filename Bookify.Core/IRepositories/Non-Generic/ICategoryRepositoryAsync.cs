namespace Bookify.Core.IRepositories.Non_Generic
{
	public interface ICategoryRepositoryAsync : IGenericRepositoryAsync<Category>
	{
		Task<bool> IsCategoryExist(string name);
	}
}
