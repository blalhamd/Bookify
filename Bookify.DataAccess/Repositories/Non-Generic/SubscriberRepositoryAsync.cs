namespace Bookify.DataAccess.Repositories.Non_Generic
{
    public class SubscriberRepositoryAsync : GenericRepositoryAsync<Subscriber>, ISubscriberRepositoryAsync
    {
        private readonly AppDbContext _appDbContext;
        public SubscriberRepositoryAsync(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

		public async Task<IList<GroupedSubscriber>> GetSubscriberDashboard()
        {
            var query = await _appDbContext.subscribers.Include(x=> x.Governorate)
                                                       .GroupBy(x=> x.Governorate!.Name)
                                                       .Select(x=> new GroupedSubscriber
                                                       {
                                                           City = x.Key,
                                                           SubscribersCount = x.Count()
                                                       })
                                                       .ToListAsync();

            return query;
        }
	}
}
