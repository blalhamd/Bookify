namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class AuthorRepositoryAsync : GenericRepositoryAsync<Author>, IAuthorRepositoryAsync
	{
		public AuthorRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
