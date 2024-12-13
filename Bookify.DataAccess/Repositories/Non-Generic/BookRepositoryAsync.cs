namespace Bookify.DataAccess.Repositories.Non_Generic
{
	public class BookRepositoryAsync : GenericRepositoryAsync<Book>, IBookRepositoryAsync
	{
        private AppDbContext _context;
		public BookRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
		{
            _context = appDbContext;
		}

        public async Task<IList<Book>> GetLastEightBooks()
        {
           return await _context.Books.AsNoTracking()
                                      .OrderByDescending(x => x.Id)
                                      .Take(8)
                                      .Include(x => x.Author)
                                      .ToListAsync();
        }

		public async Task<IList<BookSearchResult>> FindAsync(string searchTerm)
		{
			var query = await _context.Books.Include(x => x.Author)
									  .Where(
											   b => !b.IsDeleted &&
											   (b.Title.ToLower().Contains(searchTerm.ToLower()) ||
											   b.Author.Name.ToLower().Contains(searchTerm.ToLower()))
											)
									  .Select(b => new BookSearchResult
									  {
										  Id = b.Id.ToString(),
										  Title = b.Title
									  })
									  .ToListAsync();

			return query;
		}
	}
}
