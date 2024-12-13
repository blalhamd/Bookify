namespace Bookify.Core.IServices
{
    public interface IGovernorateService
	{
        Task<IList<GovernorateViewModel>> GetAllAsync();
    }
}
