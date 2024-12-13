namespace Bookify.Core.IServices
{
    public interface IAreaService
	{
		Task<IList<AreaViewModel>> GetAllAsync();
	}
}
