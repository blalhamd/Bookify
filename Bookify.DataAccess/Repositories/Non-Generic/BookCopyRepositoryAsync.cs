namespace Bookify.DataAccess.Repositories.Non_Generic
{
    public class BookCopyRepositoryAsync : GenericRepositoryAsync<BookCopy>, IBookCopyRepositoryAsync
	{
        public BookCopyRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
