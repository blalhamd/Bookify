namespace Bookify.Core.IRepositories.Non_Generic
{
    public interface ISubscriberRepositoryAsync : IGenericRepositoryAsync<Subscriber>
    {
		Task<IList<GroupedSubscriber>> GetSubscriberDashboard();

	}
}
