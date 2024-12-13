namespace Bookify.Core.IRepositories.Generic
{
	public interface IGenericRepositoryAsync<T> where T : BaseEntity
	{
		Task<int> CountAsync();
		Task<IList<T>> GetAllAsync();
		Task<IList<T>> GetAllAsync(string[] includes = null!);
		Task<T> GetByIdAsync(object id);
		Task<T> GetByIdAsync(object id, string[] includes = null!);
		Task<T> FirstOrDefaultAsync(Expression<Func<T,bool>> expression);
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(object id);
		Task DeleteAsync(T entity);
	}
}
