namespace Bookify.Core.IServices
{
    public interface ISubscriberService
	{
        Task<IList<SubscriberViewModel>> GetAllAsync();
        Task<SubscriberViewModel> GetByIdAsync(int id);
        Task<int> CreateAsync(SubscriberRequestViewModel model);
        Task<int> UpdateAsync(int id, SubscriberRequestViewModel model);
        Task DeleteAsync(int id);
        Task RenewSubscription(int subscriberId);
        Task<int> Count();
        Task<IList<GroupedSubscriber>> GetSubscriberDashboard();
    }
}
