namespace Bookify.Business.Services
{
	public class ImageService : IImageService
	{
		private readonly IWebHostEnvironment _webHostEnvironment;

		public ImageService(IWebHostEnvironment webHostEnvironment)
		{
			_webHostEnvironment = webHostEnvironment;
		}

		public async Task<string> getUniqueNameFile(IFormFile image, bool DeleteIfExist = false, string oldPath = null)
		{

			if (DeleteIfExist)
			{
				var imagePath = "";

				if (oldPath is not null)
				{
					imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", oldPath);
				}

				if (File.Exists(imagePath))
				{
					File.Delete(imagePath);
				}
			}

			string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");

			string UniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
			string FilePath = Path.Combine(UploadsFolder, UniqueFileName);

			using (var fileStream = new FileStream(FilePath, FileMode.OpenOrCreate))
			{
				await image.CopyToAsync(fileStream);
				fileStream.Close();
			}

			return UniqueFileName;
		}

		public async Task getUniqueNameFile(bool DeleteIfExist = false, string oldPath = null)
		{
			var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", oldPath);

			if (DeleteIfExist)
			{
				if (File.Exists(imagePath))
				{
					File.Delete(imagePath);
				}
			}
		}
	}
}
