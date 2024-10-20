namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class BookRepositoryAsync : GenericRepositoryAsync<Book>, IBookRepositoryAsync
	{
		public BookRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
		}
	}
}
