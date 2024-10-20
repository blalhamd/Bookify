namespace Bookify.DataAccess.Repositories.Generic
{
	public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : BaseEntity
	{
		private readonly AppDbContext _appDbContext;
		private DbSet<T> _entity;

		public DbSet<T> Entity { get => _entity; set => _entity = value; }

		public GenericRepositoryAsync(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
			_entity = _appDbContext.Set<T>();
		}

		public async Task<IList<T>> GetAllAsync()
		{
			return await _entity.ToListAsync();
		}

		public async Task<T> GetByIdAsync(object id)
		{
			return await _entity.FirstOrDefaultAsync(x => x.Id == (int)id);
		}

		public async Task AddAsync(T entity)
		{
			await _entity.AddAsync(entity);
		}

		public async Task UpdateAsync(T entity)
		{
			await Task.Run(() =>
			{
				_entity.Update(entity);
			});
		}
		public async Task DeleteAsync(object id)
		{
			var entity = await _entity.FirstOrDefaultAsync(x => x.Id == (int)id);

			await DeleteAsync(entity!);
		}


		public async Task DeleteAsync(T entity)
		{
			await Task.Run(() =>
			{
				_entity.Remove(entity);
			});
		}

	}
}
