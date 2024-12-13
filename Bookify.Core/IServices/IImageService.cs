namespace Bookify.Core.IServices
{
	public interface IImageService
	{
		Task<string> getUniqueNameFile(IFormFile image, bool DeleteIfExist = false, string oldPath = null);
		Task getUniqueNameFile(bool DeleteIfExist = false, string oldPath = null);
	}
}
