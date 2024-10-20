namespace Bookify.Core.IRepositories.Generic
{
	public interface IGenericRepositoryAsync<T> where T : BaseEntity
	{
		Task<IList<T>> GetAllAsync();
		Task<T> GetByIdAsync(object id);
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(object id);
		Task DeleteAsync(T entity);
	}
}
